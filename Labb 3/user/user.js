var user = {
    login: function(username, pwd){
        if(username !== "Johanna" || username === ""){
            console.log("Användarnamn inkorrekt");
            
        }else{
            console.log("Användarnamn korrekt");
        }
        
        if(pwd !== "pwd1" || pwd === ""){
            console.log("Lösenord inkorrekt");
        }else{
            console.log("Lösenord korrekt");
        }
        
        if(username === "Johanna" && pwd === "pwd1"){
            isValidated(username, pwd);
        }else{
            console.log("Användaren finns inte");
        }
        
        function isValidated(username, pwd){
            console.log("Användaren är validerad"); 
            if(username === "Johanna" && pwd ==="pwd1"){
                console.log("Användaren är domare");
            }else{
                console.log("Användaren är inte domare");
            }
        }
    }
    
    
};

