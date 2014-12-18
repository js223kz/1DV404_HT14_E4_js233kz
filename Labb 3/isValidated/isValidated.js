var validated = {
    
    login: function(username, pwd){
        if(username === "Johanna" && pwd === "pwd1"){
            isValidated();
        }else{
            console.log("Användaren finns inte");
        }
        
        
    }
};
function isValidated(){
    console.log("Användaren är validerad");
}
