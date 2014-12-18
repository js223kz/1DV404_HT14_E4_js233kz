"use strict";
var myTest = {
    
    init : function(){
    //Rätt användarnamn, rätt lösen, behörighet domare
    var userOne = new login.newLogin("Johanna", "pwd1");   
    
    //Rätt användarnamn, rätt lösen, behörighet gymnast
    var userTwo = new login.newLogin("Anna", "pwd2");
   
   //Fel användarnamn, Rätt lösen
    var userThree = new login.newLogin("jojo", "pwd1");
    
    //Rätt användarnamn, fel lösen
    var userFour = new login.newLogin("Johanna", "pwd3");
    
    //lösen och användarnamn finns, men kopplat till olika personer
    var userFive = new login.newLogin("Anna", "pwd1");
    }
};
window.onload = myTest.init;