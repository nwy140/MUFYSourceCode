word = "sunway"

turns=10

guesses = ""




while turns !=0:
    
    currentGuess = True
    for letter in word:
        if letter in guesses:
            print(letter)
        else:
            print('_')
    if currentGuess:
            print ("You WOn")
            break
    guess = input("guess a letter:")
    guesses = guesses + guess
    if guess not in word:
        print("Try Again")
        turns= turns-1
        if turns     == 0:
            print("YouLose")
