/// <reference path="./global.d.ts" />
// @ts-check

/**
 * Implement the functions needed to solve the exercise here.
 * Do not forget to export them so they are available for the
 * tests. Here an example of the syntax as reminder:
 *
 * export function yourFunction(...) {
 *   ...
 * }
 */

export function cookingStatus(remainingTime) {
    if (Number(remainingTime) === 0) return 'Lasagna is done.';
    return !remainingTime ? 'You forgot to set the timer.' : 'Not done, please wait.';
}

export function preparationTime(layers, averagePreparationTime = 2) {
    return layers.length * averagePreparationTime;
}

export function quantities(layers) {
    return {
        noodles: layers.filter(ingredient => ingredient === 'noodles').length * 50,
        sauce:  layers.filter(ingredient => ingredient === 'sauce').length * 0.2,
    };
}

export function addSecretIngredient (friendsList, myList) {
    myList.push(friendsList[friendsList.length - 1]);    
}

export function scaleRecipe (recipe, numberOfPortions) {
    let newRecipe = {...recipe};
    for (const key in newRecipe) {
        newRecipe[key] *= numberOfPortions / 2;        
    }
    return newRecipe;    
}     