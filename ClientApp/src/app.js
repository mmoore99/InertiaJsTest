/* eslint-disable */
import Vue from "vue";
import { InertiaApp } from "@inertiajs/inertia-vue";

Vue.use(InertiaApp);

const app = document.getElementById("app");
//debugger;
new Vue({
    render: h => h(InertiaApp, {
        props: {
            initialPage: JSON.parse(app.dataset.page),
            resolveComponent: name => import(`@/Pages/${name}`).then(module => module.default)
        }
    })
}).$mount(app);
