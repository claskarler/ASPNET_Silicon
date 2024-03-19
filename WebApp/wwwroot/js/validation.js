const formErrorHandler = (e, validationResult) => {
    let spanElement = document.querySelector(`[data-valmsg-for="${e.target.name}"]`);

    if (validationResult) {
        e.target.classList.remove('input-validation-error');
        spanElement.classList.remove('field-validation-error');
        spanElement.classList.add('field-validation-valid');
        spanElement.innerHTML = '';
    } else {
        e.target.classList.add('input-validation-error');
        spanElement.classList.add('field-validation-error');
        spanElement.classList.remove('field-validation-valid');
        spanElement.innerHTML = e.target.dataset.valRequired;
    }
}

const compareValidator = (value, comparedValue) => {
    return value === comparedValue;
}

const textValidator = (e, minLength = 2) => {
    if (e.target.value.length >= minLength) {
        formErrorHandler(e, true);
    } else {
        formErrorHandler(e, false);
    }
}

const emailValidator = (e) => {
    const regEx = /^(([^<>()[\]\.,;:\s@\"]+(\.[^<>()[\]\.,;:\s@\"]+)*)|(\".+\"))@(([^<>()[\]\.,;:\s@\"]+\.)+[^<>()[\]\.,;:\s@\"]{2,})$/i;
    formErrorHandler(e, regEx.test(e.target.value));
}

const passwordValidator = (e) => {
    if (e.target.dataset.valEqualtoOther !== undefined) {
        const comparedValue = document.getElementsByName(e.target.dataset.valEqualtoOther.replace('*', 'Form'))[0].value;
        const validationResult = compareValidator(e.target.value, comparedValue);
        formErrorHandler(e, validationResult);
        if (validationResult) {
            const spanElement = document.querySelector(`[data-valmsg-for="${e.target.name}"]`);
            spanElement.classList.remove('field-validation-error');
            spanElement.classList.add('field-validation-valid');
            spanElement.innerHTML = '';
        }
    } else {
        const regEx = /^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*])(?=.{8,})/;
        formErrorHandler(e, regEx.test(e.target.value));
    }
}

const checkboxValidator = (e) => {
    if (e.target.checked) {
        formErrorHandler(e, true);
    } else {
        formErrorHandler(e, false);
    }
}

let forms = document.querySelectorAll('form');
let inputs = forms[0].querySelectorAll('input');

inputs.forEach(input => {
    if (input.dataset.val === 'true') {
        if (input.type === 'checkbox') {
            input.addEventListener('change', checkboxValidator);
        } else {
            input.addEventListener('keyup', (e) => {
                switch (e.target.type) {
                    case 'text':
                        textValidator(e);
                        break;
                    case 'email':
                        emailValidator(e);
                        break;
                    case 'password':
                        passwordValidator(e);
                        break;
                }
            });
        }
    }
});