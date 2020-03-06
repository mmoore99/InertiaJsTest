<template>
    <div id="App">
        <div class="">
            <!--<nav-bar></nav-bar>-->
            <img alt="Vue logo" src="/images/logo.png" />
            <hello-world></hello-world>
        </div>
    </div>
</template>

<script>

    // @ is an alias to /src
    import NavBar from "@/Components/NavBar.vue";
    import HelloWorld from "./HelloWorld.vue";
    import { store } from "../../store.js";

    export default {
        name: "Index",
        layout: NavBar,
        props: {

        },
        components: {
            NavBar,
            HelloWorld
        },
        data() {
            return {
                fb,
                storeState: store.state,
                protoState: this.$store.state
            };
        },
        created() {
            store.setCurrentPageAction("Home/Index");
        },
        mounted() {

        },
        methods: {

        },

        computed: {

        }
    };

</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>

  #App {
    font-family: 'Avenir', Helvetica, Arial, sans-serif;
    -webkit-font-smoothing: antialiased;
    -moz-osx-font-smoothing: grayscale;
    text-align: center;
    color: #2c3e50;
  }

</style>
