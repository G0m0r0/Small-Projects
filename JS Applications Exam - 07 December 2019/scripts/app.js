import controllers from '../controllers/index.js';

const app=Sammy('#root',function(){
    this.use('Handlebars','hbs');

    //home
    this.get('#/home',controllers.home.get.home);

    //user
    this.get('#/user/login',controllers.user.get.login);
    this.get("#/user/register", controllers.user.get.register);

    this.post("#/user/login",controllers.user.post.login);
    this.post("#/user/register",controllers.user.post.register);
    this.get("#/user/logout",controllers.user.get.logout);
    //trecks

    this.get('#/treck/dashboard',controllers.treck.get.dashboard);
    this.get("#/treck/create",controllers.treck.get.create);
    this.get('#/user/profile',controllers.user.get.profile);
    this.get("#/treck/details/:treckId",controllers.treck.get.details);

    this.post('#/treck/create',controllers.treck.post.create);
    
    this.get("#/treck/close/:treckId",controllers.treck.del.close);
    this.get('#/treck/like/:treckId',controllers.treck.put.update);

    this.get('#/treck/edit/:treckId',controllers.treck.get.edit);
});

(()=>{
    app.run('#/home');
})();   