
Console.WriteLine("======================= BEGIN PROBLEM 1 ==============================");

/*

1) 
    Instantiate an array of ints of length 10. Write a loop that populates the array
    with values starting at 10. The array should look like the following after the loop:
        arr[0] = 10
        arr[1] = 11
        arr[2] = 12
        arr[3] = 13
        arr[4] = 14
            ...
            (etc)
    
    Then, write a loop to go through the array backwards and print out the value
    at each index on each iteration.

*/

int intArray = 
for(let x = 0; x < intArray.length; x++){
    
}

Console.WriteLine("======================= END PROBLEM 1 ==============================");


Console.WriteLine("======================= BEGIN PROBLEM 2 ==============================");
/*

2)
    The following code is an example of how you can prompt the user for input and then
    read that input via the user entering text into the terminal.

    After tyring out the below code to see how it works, let's modify the code in the following
    way..

    Once you read in the input from the user, try to parse that number they entered
    into an integer. If the user did in fact enter an integer, then print out: 
        
        "The integer you entered is: " + <the_integer_they_entered>

    Otherwise, print out:
        "You must enter an integer."

    **Hint: remember how we have converted text to an int in our form example!**
*/

    // Type your number and press enter
    Console.WriteLine("Enter an integer:");

    // Create a string variable and get user input from the keyboard and store it in the variable
    string number = Console.ReadLine();

    // Print the value of the variable (userName), which will display the input value
    Console.WriteLine("Number entered is: " + number);

Console.WriteLine("======================= END PROBLEM 2 ==============================");

Console.WriteLine("======================= BEGIN PROBLEM 3 ==============================");

/*

3)
    Let's take our processing of user input a bit further...
    Create an array of integers of length 5. Then write a loop that prompts
    the user to enter an integer and adds that integer to the array of ints that
    you created. Continue to prompt the user for input until the array is full.
    
    Consider the following algorithm to accomplish this:
        - Once the user has entered their input, try to parse what they entered into an int. If what 
            they entered was indeed an integer, add that integer to the array and proceed to the next index
            of the array to add another value into it.

        - If what the user entered was not an integer, then tell the user that they must enter
            an integer, and do **not** proceed to the next index of the array until they have given you
            an integer input.
    
    ** Also: make sure that after receiving all of the user input, you write another loop to print out the 
            contents of the array you created so that you can see that you have populated the properly!
        
    Hint: Think about using a boolean variable to signify that the array has been
            filled completely and thus we can end our loop.

            - Think about which kind of loop we would want to use for gathering the user input... A for-loop? Or a while-loop?
                One will suite this problem better than the other.

*/

Console.WriteLine("======================= END PROBLEM 3 ==============================");

Console.WriteLine("======================= BEGIN PROBLEM 4 ==============================");
/*

4)

    Go through every word in this sentence, and every letter in each word, and do the following replacements regardless
    of if the letter is uppercase or lowercase:

    a => @ (replace 'a' with '@')
    o => 0 (replace 'o' with '0' {zero})
    l => 1 (replace 'l' with '1' {one})
    e => 3 (replace 'e' with '3')

    Once you have done these replacements, print out the new sentence you have created to the console.

    **Hint: remember our form example which does something similar to this.
*/

    string sentence = "All the apples in the Alexandria Orchard are ready to be picked.";
    

Console.WriteLine("======================= END PROBLEM 4 ==============================");
