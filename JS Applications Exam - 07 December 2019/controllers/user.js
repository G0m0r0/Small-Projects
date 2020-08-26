import models from '../models/index.js';
import extend from '../utilities/context.js';
import docModified from '../utilities/doc-modified.js';

export default {
    get:{
        login(context){
           // console.log(context);

            extend(context).then(function(){       
                this.partial('../views/user/login.hbs');
            })
        },
        register(context){
            extend(context).then(function(){
                this.partial('../views/user/register.hbs');
            })
        },
        logout(context){
            models.user.logout().then(response=>{
                context.redirect('#/home');
            })},
        profile(context){                         
            models.treck.getAll().then(response=>{
                //console.log(response);
                const trecks=response.docs.map(docModified);

                let dataOfProfile={
                    countTrecks: 0,
                    nameTrecks: [],
                };

                trecks.forEach(el=>{
                    if(el.data.uid===localStorage.getItem('userId')){
                        dataOfProfile.countTrecks++;
                        dataOfProfile.nameTrecks.push(el.data.location);
                    }
                });

                if(dataOfProfile.nameTrecks.length===0){
                    dataOfProfile.nameTrecks="No treks";
                }

                context.dataOfProfile=dataOfProfile;

                 extend(context).then(function(){
                    this.partial('../views/user/profile.hbs');
                }) 
            });
        }
    },
    post: {
        login(context){
            //console.log(context);
            const {username,password}=context.params;
            //console.log(username);
           // console.log(password);
           
                 const notification=document.getElementById('notifications');
                 const message=document.createElement('div');
                 message.setAttribute('id','seccessBox');
                 message.setAttribute('class','alert alert-success');
                 message.setAttribute('role','alert');
                 message.innerHTML='Successful login';
                 notification.appendChild(message);
                 message.style.display='block';
                 setTimeout(() => message.style.display = 'none', 5000); 

            models.user.login(username,password)
            .then(response=>{
                context.user=response;
                context.username=response.email;
                context.isLoggedIn=true;

                context.redirect('#/treck/dashboard');
            })
            .catch(error=>{
                console.error(error);
            })
        },
        register(context){
            const {username,password,rePassword}=context.params;

            if(password===rePassword){
                models.user.register(username,password)
                .then(response=>{
                    context.redirect("#/treck/dashboard");
                })
                .catch(error=>{
                    console.error(error);
                })
            }
        }
    }
}