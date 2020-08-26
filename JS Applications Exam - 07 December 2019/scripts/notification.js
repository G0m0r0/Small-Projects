/* import { get, post, put, del } from "./requester.js";

const app = Sammy('#container', function () {
    this.use('Handlebars', 'hbs');

    this.get('#/home', function (ctx) {
        setHeaderInfo(ctx);

        if (ctx.isLogged) {
            get('appdata', 'cars', 'Kinvey')
                .then((cars) => {
                    cars.map(x => x.isCreator = x._acl.creator === sessionStorage.getItem('userId') ? true : false);
                    ctx.cars = cars;
                    this.loadPartials(getPartials())
                        .partial('./views/home/home.hbs');
                })
        } else {
            this.loadPartials(getPartials())
                .partial('./views/home/home.hbs');
        }
    })

    this.get('#/register', function (ctx) {
        setHeaderInfo(ctx);

        this.loadPartials(getPartials())
            .partial('./views/user/register.hbs');
    })

    this.get('#/login', function (ctx) {
        setHeaderInfo(ctx);

        this.loadPartials(getPartials())
            .partial('./views/user/login.hbs');
    })

    this.post('#/register', function (ctx) {
        setHeaderInfo(ctx);

        const { username, password, repeatPass } = ctx.params;

        if (username.length >= 3 && password.length >= 6 && password === repeatPass) {
            post('user', '', { username, password }, 'Basic')
                .then((userInfo) => {
                    saveAuthInfo(userInfo);
                    ctx.redirect('#/home');
                    displaySuccess('User registration successful.');
                })
                .catch(() => displayError('Invalid username/password'));
        } else {
             displayError('Invalid username/password')
        }
    })

    this.get('#/logout', function (ctx) {
        setHeaderInfo(ctx);

        post('user', '_logout', {}, 'Kinvey')
            .then(() => {
                sessionStorage.clear();
                ctx.redirect('#/home');
                displaySuccess('Logout successful.');
            })
            .catch(console.error);
    })

    this.post('#/login', function (ctx) {
        setHeaderInfo(ctx);

        const { username, password } = ctx.params;

        if (username && password) {
            post('user', 'login', { username, password }, 'Basic')
                .then((userInfo) => {
                    saveAuthInfo(userInfo);
                    ctx.redirect('#/home');
                    displaySuccess('Login successful.');
                })
                .catch(() => displayError('Invalid credentials. Please retry your request with correct credentials.'));
        }
    })

    this.get('#/car/create', function (ctx) {
        setHeaderInfo(ctx);

        this.loadPartials(getPartials())
            .partial('./views/car/create.hbs');
    })

    this.post('#/car/create', function (ctx) {
        setHeaderInfo(ctx);

        const { title, description, brand, model, year, imageUrl, fuelType, price } = ctx.params;

        post('appdata', 'cars', { title, description, brand, model, year, imageUrl, fuelType, price, seller: sessionStorage.getItem('username') }, 'Kinvey')
            .then(() => {
                ctx.redirect('#/home');
                displaySuccess('Listing created.');
            })
            .catch(console.error);
    })

    this.get('#/car/edit/:id', async function (ctx) {
        setHeaderInfo(ctx);
        const id = ctx.params.id;

        const car = await get('appdata', `cars/${id}`, 'Kinvey');
        ctx.car = car;
        this.loadPartials(getPartials())
            .partial('./views/car/edit.hbs');
    })

    this.post('#/car/edit/:id', function (ctx) {
        setHeaderInfo(ctx);
        const id = ctx.params.id;
        const { title, description, brand, model, year, imageUrl, fuelType, price } = ctx.params;

        get('appdata', `cars/${id}`, 'Kinvey')
            .then((car) => {
                put('appdata', `cars/${id}`, { title, description, brand, model, year, imageUrl, fuelType, price, seller: car.seller }, 'Kinvey')
                    .then(() => {
                        ctx.redirect('#/home');
                        displaySuccess(`Listing ${title} updated.`);
                    })
                    .catch(console.error);
            })
    })

    this.get('#/car/delete/:id', function (ctx) {
        setHeaderInfo(ctx);
        const id = ctx.params.id;

        del('appdata', `cars/${id}`, 'Kinvey')
            .then(() => {
                ctx.redirect('#/home');
                displaySuccess('Listing deleted.');
            })
            .catch(()=>displayError('Internet connection lost.'));
    })

    this.get('#/user/listings', function (ctx) {
        setHeaderInfo(ctx);

        get('appdata', 'cars', 'Kinvey')
            .then((cars) => {
                cars = cars.filter(x => x._acl.creator === sessionStorage.getItem('userId'));
                ctx.cars = cars;
                this.loadPartials(getPartials())
                    .partial('./views/user/listings.hbs');
            })
            .catch(console.error);
    })

    this.get('#/car/details/:id', async function (ctx) {
        setHeaderInfo(ctx);
        const id = ctx.params.id;

        const car = await get('appdata', `cars/${id}`, 'Kinvey');
        car.isOwner = car._acl.creator === sessionStorage.getItem('userId') ? true : false;
        ctx.car = car;
        this.loadPartials(getPartials())
            .partial('./views/car/details.hbs');
    })

})
app.run()

function setHeaderInfo(ctx) {
    ctx.isLogged = sessionStorage.getItem('authtoken') !== null;
    ctx.username = sessionStorage.getItem('username');
}

function saveAuthInfo(userInfo) {
    sessionStorage.setItem('authtoken', userInfo._kmd.authtoken);
    sessionStorage.setItem('username', userInfo.username);
    sessionStorage.setItem('userId', userInfo._id);
}

function getPartials() {
    return {
        header: '../views/common/header.hbs',
        footer: '../views/common/footer.hbs',
        loggedIn: '../views/home/loggedIn.hbs'
    }
}

function displaySuccess(message) {
    const element = document.querySelector('#infoBox > span');
    const div = document.querySelector('#infoBox');
    element.textContent = message;
    div.style.display = 'block';

    div.addEventListener('click', () => div.style.display = 'none');

    setTimeout(() => div.style.display = 'none', 3000);
}

function displayError(message) {
    const element = document.querySelector('#errorBox > span');
    const div = document.querySelector('#errorBox');
    element.textContent = message;
    div.style.display = 'block';

    div.addEventListener('click', () => div.style.display = 'none'); */