"use strict";
var myTest = {
    
    init : function(){
    //Fel användarnamn
    var userOne = new username.login("Anna");   
    
    //Tom sträng
    var userTwo = new username.login("");
    
    //Rätt användarnamn
    var userThree = new username.login("Johanna");
    
    //Rätt användarnamn men med versaler
    var userFour = new username.login("JOHANNA");
    }
};
window.onload = myTest.init;