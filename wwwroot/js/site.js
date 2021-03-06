﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


let dropdown = document.getElementById('locality-dropdown');
dropdown.length = 0;

let defaultOption = document.createElement('option');
defaultOption.text = 'Choose State/Province';

dropdown.add(defaultOption);
dropdown.selectedIndex = 0;

const url = 'https://api.myjson.com/bins/7xq2x';

const request = new XMLHttpRequest();
request.open('GET', url, true);

request.onload = function () {
    if (request.status === 200) {
        const data = JSON.parse(request.responseText);
        let option;
        for (let i = 0; i < data.length; i++) {
            option = document.createElement('option');
            option.text = data[i].name;
            option.value = data[i].abbreviation;
            dropdown.add(option);
        }
    } else {
        // Reached the server, but it returned an error
    }
}

request.onerror = function () {
    console.error('An error occurred fetching the JSON from ' + url);
};

request.send();
