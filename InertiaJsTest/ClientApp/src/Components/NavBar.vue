<template>
    <div class="single-root-element">
        <div id="App" class="app-slot">
            <div id="nav">
                <inertia-link href="/Home/Index">Home</inertia-link>  |
                <inertia-link href="/Home/SampleApi">Sample API</inertia-link>  |
                <inertia-link href="/Home/About">About</inertia-link>
            </div>
            <slot />
        </div>
    </div>
</template>

<script>

    // @ is an alias to /src
    //import HelloWorld from '@/components/HelloWorld.vue'

    const EventIds = {
        newPageLoaded: "new-page-loaded",
    };

    export default {
        name: "NavBar",
        props: {

        },
        components: {

        },
        data() {
            return {
            };
        },
        created() {
            this.$root.$on(EventIds.newPageLoaded, (pageName) => {
                console.log(`New page loaded: pageName=${pageName}`);
            });
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

    #nav {
        padding: 30px;
    }

        #nav a {
            font-weight: bold;
            color: #2c3e50;
        }

            #nav a.router-link-exact-active {
                color: #42b983;
            }
</style>
