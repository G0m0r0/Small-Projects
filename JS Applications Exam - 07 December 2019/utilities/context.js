export default function(context){

        firebase.auth().onAuthStateChanged(function(user) {
            if (user) {
              // User is signed in.
             // console.log(user);
              context.isLoggedIn=true;
              context.userId=user.uid;
              context.username=user.email;    

              localStorage.setItem('userId',user.uid);
              localStorage.setItem('userEmail',user.email)
              
              
              // ...
            } else {
              // User is signed out.
             // console.log('not logged');
              context.isLoggedIn=false;
              context.userId=null;
              context.username=null;

              localStorage.removeItem('userId');
              localStorage.removeItem('userEmail');
              context.username=null;
              // ...
            }
          }); 

    return context.loadPartials({
        header: "../views/common/header.hbs",
        footer: "../views/common/footer.hbs",
    })
}