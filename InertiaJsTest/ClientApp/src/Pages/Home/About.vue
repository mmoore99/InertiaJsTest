<template>
    <div class="about">
        <h1>This is an about page</h1>
        <h2>{{ msg }}</h2>
        <h2>{{ msgShare1 }}</h2>
        <h2>{{ msgShare2 }}</h2>
    </div>
</template>


<script>

    // @ is an alias to /src
    import NavBar from "@/Components/NavBar.vue";
    import { store } from "../../store.js";

    export default {
        name: "About",
        layout: NavBar,
        props: {
            msg: String,
            msgShare1: String,
            msgShare2: String
        },
        components: {

        },
        data() {
            return {
                storeState: store.state,
            };
        },
        created() {
        },
        mounted() {
            store.setCurrentPageAction("Home/About");
        },
        methods: {

        },

        computed: {

        }
    };

</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
</style>
