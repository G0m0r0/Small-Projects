import extend from '../utilities/context.js';
import models from '../models/index.js';
import docModified from '../utilities/doc-modified.js';
import treck from '../models/treck.js';

export default {
    get:{
        dashboard(context){

            models.treck.getAll().then(response=>{
                const trecks=response.docs.map(docModified);
                //console.log(trecks);
                             
                 context.trecks=trecks.sort(function(a,b){
                     return b.data.collectedLikes-a.data.collectedLikes;
                 });

                extend(context).then(function(){
                    this.partial('../views/home/home.hbs');
                }) 
            });
            
        },       
        create(context){
            extend(context).then(function(){
                //console.log('hi');
                this.partial('../views/treck/create.hbs');
            })
        },
        edit(context){
            const {treckId}=context.params;        

             

            models.treck.get(treckId).then(async (response)=>{
                const treck=docModified(response);
                let location=document.getElementsByTagName('input')[0];
                let date=document.getElementsByTagName('input')[1];
                let description=document.getElementsByTagName('textarea')[0];
                let image=document.getElementsByTagName('input')[2];
                let button=document.getElementsByTagName('button')[0];
                //console.log(button);

                location.value=treck.data.location;
                date.value=treck.data.dateTime;
                description.value=treck.data.description;
                image.value=treck.data.imageURL;

                await button.addEventListener('click', (e)=>{
                    e.preventDefault();

                    treck.data.location=location.value;
                    treck.data.dateTime=date.value;
                    treck.data.description=description.value;
                    treck.data.imageURL=image.value;
                    
                    models.treck.update(treckId,treck).then(response=>{
                         context.redirect(`#/treck/details/${treckId}`);
                    })                
                })                            
            }).catch(error=>console.error(error));

            extend(context).then(function(){
                this.partial('../views/treck/edit.hbs');
            }); 
        },
         details(context){
            const {treckId}=context.params;
            //console.log(treckId);

             models.treck.get(treckId).then(response=>{
                //console.log(response);
                const treck=docModified(response);
                //console.log(cause);

                Object.keys(treck).forEach(key=>{
                    context[key]=treck[key];
                    //console.log(key);
                    //console.log(context[key])
                });

                context.canEdit=treck.data.creator===localStorage.getItem('userEmail');
                //console.log(context.canEdit);

                extend(context).then(function(){
                    this.partial('../views/treck/details.hbs');
                }) 

            }).catch(error=>console.error(error));
        } 
    },
    post:{
         create(context){

            const data={
                ...context.params, 
                uid: localStorage.getItem('userId'),
                collectedLikes:0,
                creator: localStorage.getItem('userEmail')
            };
            //console.log(data);

            models.treck.create(data).then(response=>{
                //console.log(response);
                context.redirect('#/treck/dashboard');
            }).catch(e=>console.error(e));
        } 
    },
    del:{
         close(context){
            const {treckId}=context.params;

            models.treck.close(treckId).then(response=>{
                context.redirect('#/treck/dashboard');
            })
        } 
    },
    put: {
         update(context){
            const {treckId}=context.params;

            models.treck.get(treckId).then(response=>{
                const treck=docModified(response);
                //console.log(treck);

                treck.data.collectedLikes++;

                return models.treck.update(treckId,treck);
            }).then(response=>{
                //console.log(context);
                context.redirect(`#/treck/details/${context.params.treckId}`);
            })

        },
        edit(context){
            console.log('brrr');

            let input=document.getElementsByTagName('input')[0];
            input.value="Hello";
        }
    },
    patch: {
        async edit(context){
            console.log('brrr');

            const {treckId}=context.params;

           let form=document.querySelector('form');
           console.log(form);
        }
    }
}