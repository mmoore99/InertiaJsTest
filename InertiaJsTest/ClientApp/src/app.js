/* eslint-disable */
import Vue from "vue";
import { InertiaApp } from "@inertiajs/inertia-vue";

Vue.use(InertiaApp);
Vue.config.ignoredElements = [/^ion-/];

window.fb = "default value";
//fb.store = {
//    debug: true,
//    state: {
//        currentPage: "Home/Index"
//    },
//    setCurrentPageAction(newValue) {
//        if (this.debug) console.log("setCurrentPageAction triggered with", newValue);
//        this.state.currentPage = newValue;
//    },
//    clearCurrentPageAction() {
//        if (this.debug) console.log("clearCurrentPageAction triggered");
//        this.state.message = "";
//    }
//};
//console.log(fb.store);

Vue.prototype.$store = {
    state: {
        numbers: [20, 30, 40]
    },
    addNumber(newNumber) {
        this.state.numbers.push(newNumber);
    }
};

const app = document.getElementById("app");

new Vue({
    created() {

    },
    render: h => h(InertiaApp, {
        props: {
            initialPage: JSON.parse(app.dataset.page),
            resolveComponent: name => import(`@/Pages/${name}`).then(module => module.default)
        }
    })
}).$mount(app);
