export default{
    register(username,password){

        return firebase.auth().createUserWithEmailAndPassword(username,password);
    },
    login(username,password){

        return firebase.auth().signInWithEmailAndPassword(username,password);
    },
    logout(){
        return firebase.auth().signOut();
    },
    get(id){
        return firebase.firestore().collection('treks').doc(id).get(); //make request to specific document with id
    }
};