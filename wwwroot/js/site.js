//Animacija texta na Home stranici
let textTag = document.querySelector('.section h1');
let text = textTag.textContent;


let splittedText = text.split('');

textTag.innerHTML = '';

for (i = 0; i < splittedText.length; i++) {
    if (splittedText[i] == " ") {
        splittedText[i] = "&nbsp;";
    }
    textTag.innerHTML += `<span>${splittedText[i]}</span >`
}

let k = 0;
let interval = setInterval(() => {
    let spans = textTag.querySelectorAll('span');
    let singleSpan = spans[k];
    singleSpan.classList = 'fadeMove';
    k++;

    if (k === spans.length) {
        clearInterval(interval);
    }
}, 70);

//Spajanje kartica
let leftCard = document.querySelector('.slideLeft');
let rightCard = document.querySelector('.slideRight');

leftCard.classList.add('animated');
rightCard.classList.add('animated');
