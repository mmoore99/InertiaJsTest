<template>
    <div class="single-root-element">
        <div id="App" class="app-slot">
            <div id="nav">
                <inertia-link href="/Home/Index" :class="{'current-page': isCurrentPage('Home/Index')}">Home</inertia-link>  |
                <inertia-link href="/Home/SampleApi">Sample API</inertia-link>  |
                <inertia-link href="/Home/About">About</inertia-link>
            </div>
            <div>
                <h2>{{ storeState.currentPage }}</h2>
            </div>
            <slot />
        </div>
    </div>
</template>

<script>

    // @ is an alias to /src
    import { store } from "../store.js";

    export default {
        name: "NavBar",
        props: {

        },
        components: {

        },
        data() {
            return {
                currentPage: store.state.currentPage,
                storeState: store.state,
                protoState: this.$store.state
            };
        },
        created() {
            console.log(fb);
        },
        mounted() {

        },
        methods: {
            isCurrentPage(pageName) {
                debugger;
                return pageName === this.currentPage;
            }
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
    .current-page {
        color: green;
    }
</style>
