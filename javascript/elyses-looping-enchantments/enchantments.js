// @ts-check

/**
 * Determine how many cards of a certain type there are in the deck
 *
 * @param {number[]} stack
 * @param {number} card
 *
 * @returns {number} number of cards of a single type there are in the deck
 */
export function cardTypeCheck(stack, card) {
    let total = 0;
    stack.forEach(currentCard => currentCard === card ? total += 1 : total +=0);
    return total;
}

/**
 * Determine how many cards are odd or even
 *
 * @param {number[]} stack
 * @param {boolean} type the type of value to check for - odd or even
 * @returns {number} number of cards that are either odd or even (depending on `type`)
 */
export function determineOddEvenCards(stack, type) {
    let totalEven = 0;
    for (const currentCard of stack) {
        if (currentCard % 2 === 0) {
            totalEven += 1;
        }
    }
    return type ? totalEven : stack.length - totalEven;
}
