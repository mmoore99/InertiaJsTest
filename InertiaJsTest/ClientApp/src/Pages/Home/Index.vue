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
    //import HelloWorld from '@/components/HelloWorld.vue'
    import NavBar from "@/Components/NavBar.vue";
    import HelloWorld from "./HelloWorld.vue";

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

            };
        },
        created() {

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
