def board(x,y):
    correctGuess = True
    for letter in x:
        if letter in y:
            print(letter, end = "  ")
        else:
            print("_  ", end = "")
            correctGuess = False
    return correctGuess

def wrong(guess, word, turns):
    if guess not in word:
        turns = turns - 1
        print("Wrong!")
        print("You have ",turns," more guesses.")
        if turns == 0:
            print("You lose")
    return turns
            
word = "sunway"
guesses = ""
turns = 7

while turns != 0:
    correctGuess = board(word,guesses)
    if correctGuess:
        print("\nYou won!!!")
        break
    guess = input("\nGuess a letter: ")
    while len(guess) != 1:
        print("You have entered an invalid value!")
        guess = input("\nGuess a letter: ")
    guesses = guesses + guess
    turns = wrong(guess, word, turns)
