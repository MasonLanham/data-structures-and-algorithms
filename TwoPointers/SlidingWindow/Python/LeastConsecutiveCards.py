'''
A bunch of cards is laid out in front of you in a line, where the value of each card ranges from 0 to 10^6. 
A pair of cards is matching if they have the same number value.
Given a list of integers cards, your goal is to match a pair of cards, but you can only pick up cards in a consecutive manner.
What is the minimum number of cards that you need to pick up to make a pair? If there are no matching pairs, return -1.

For example, given cards = [3, 4, 2, 3, 4, 7], then picking up [3, 4, 2, 3] makes a pair of 3s and picking up [4, 2, 3, 4] matches two 4s. 
We need 4 consecutive cards to match a pair of 3s and 4 consecutive cards to match 4s, so you need to pick up at least 4 cards to make a match.
'''

def least_consecutive_cards_to_match(cards: list[int]) -> int:
    hand = set()
    left = 0
    right = 0
    minLength = len(cards) + 1
    while right < len(cards):
        #Ensure there is only 1 pair in hand and update
        while cards[right] in hand:
            hand.remove(cards[left])
            minLength = min(minLength, right - left + 1)
            left += 1
        #Now the first of the pair has been removed
        hand.add(cards[right])
        right += 1
