var login = {
    userList : [],
    newLogin : function(username, pwd){
        
        login.userList = user.userList;
        
        login.userList.forEach(function(item){
            if(username === item.user && pwd === item.pwd){
               isValidated(item.user, item.pwd, item.authority);
            }
            if(username === item.user && pwd !== item.pwd){
                console.log("Användarnamn är rätt, Lösenord är fel!");
            }
                
            if(username !== item.user && pwd === item.pwd){
                console.log("Lösenord är rätt, Användarnamn är fel!");
            
            }
        });

        
        function isValidated(username, pwd, authority){
            console.log("Användaren är validerad som användare: " + username + " lösenord: " + pwd + " behörighet: " + authority);
        }
    }
    

};


