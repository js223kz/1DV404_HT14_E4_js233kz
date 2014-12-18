"use strict";
var myTest = {
    
    init : function(){
    //Fel användarnamn, Fel lösenord
    var userOne = new user.login("Anna", "fel");   
    
    //Tom sträng på båda
    var userTwo = new user.login("", "");
    
    //Rätt användarnamn, rätt lösenord
    var userThree = new user.login("Johanna", "pwd1");
    
    //Rätt användarnamn men med versaler
    var userFour = new user.login("JOHANNA", "PWD1");
    
    //Rätt användarnamn, fel lösenord
    var userFive = new user.login("Johanna", "pwd3");
    
    //Rätt lösenord, fel användarnamn
    var userSix = new user.login("Lisa", "pwd1");
    
    //Rätt lösenord, tomt användarnamn
    var userSeven = new user.login("", "pwd1");
    }
};
window.onload = myTest.init;