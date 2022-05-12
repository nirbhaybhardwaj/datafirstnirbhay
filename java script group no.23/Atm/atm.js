var balance =  10000.00;
//balance enquiry
function get_balance(){
    alert('Your Current Balance is: '+balance);
    atm();
}

//Deposit Money
function deposit(){
    var deposit=parseFloat(prompt('how much money you want to deposit'));
    if(isNaN(deposit)|| deposit===''){
        alert('Error: Please Enter a Number!');
        deposit();
    }
    else{
        balance+=deposit;
        get_balance();
    }
}

//Withdraw Money
function withdraw(){
    var withdraw=parseFloat(prompt('How much Money you want to withdraw'));
    if(isNaN(withdraw)||withdraw===''){
        alert('Error: Please Enter a Number');
        withdraw();
    }
    else{
        balance-=withdraw;
        get_balance();
    }
}

//Exit
function exit(){
    var confirm_leave=confirm_leave("you have selected exit");
    if(confirm_leave){
        window.close();
    }
    else{
        atm();
    }
}
//Choices 
function atm(){
    var choice=parseInt(prompt('select a choice 1.Balance 2.Deposit 3.withdraw 4. Exit'))

    if (choice ===1){
    get_balance();
    }
    else if(choice===2){
        deposit();
    }
    else if(choice===3){
        withdraw();
    }
    else if(choice===4){
        exit();
    }
}

atm();