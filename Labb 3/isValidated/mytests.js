"use strict";
var myTest = {
    
    init : function(){
    //Fel användarnamn, Fel lösenord
    var userOne = new validated.login("Anna", "fel");   
    
    //Tom sträng på båda
    var userTwo = new validated.login("", "");
    
    //Rätt användarnamn, rätt lösenord
    var userThree = new validated.login("Johanna", "pwd1");
    
    //Rätt användarnamn men med versaler
    var userFour = new validated.login("JOHANNA", "PWD1");
    
    //Rätt användarnamn, fel lösenord
    var userFive = new validated.login("Johanna", "pwd3");
    
    //Rätt lösenord, fel användarnamn
    var userSix = new validated.login("Lisa", "pwd1");
    
    //Rätt lösenord, tomt användarnamn
    var userSeven = new validated.login("", "pwd1");
    }
};
window.onload = myTest.init;