"use strict";
var myTest = {
    
    init : function(){
    //Fel användarnamn
    var pwdOne = new password.login("pwd4");   
    
    //Tom sträng
    var pwdTwo = new password.login("");
    
    //Rätt användarnamn
    var pwdThree = new password.login("pwd1");
    
    //Kontroll av rätt lösenord men med versaler
    var pwdFour = new password.login("PWD1");
    }
};
window.onload = myTest.init;