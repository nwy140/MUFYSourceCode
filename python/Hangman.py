#Hangman Game

word = "sunway"
guesses = ""
turns = 7

while turns != 0:
    correctGuess = True
    #for each character in word
    for letter in word:
        #if guesses matches with word
        if letter in guesses:
            print(letter,end="")
        else: 
            print("_  ",end="")
            correctGuess = False
    if correctGuess:
        print("\nYou won!!!")
        break
    guess = input("\nGuess a letter:")
    guesses = guesses + guess
    if guess not in word:
        turns = turns - 1
        print("Wrong!")
        print("You have ",turns," more guesses.")
        if turns == 0:
            print("You lose")
