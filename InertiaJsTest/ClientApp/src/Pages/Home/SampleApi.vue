<template>
    <div id="SampleApi" class="sample-api">
        <h1>Sample page fetching data from the SampleDataController</h1>
        <h3>These are the initial values:</h3>
        <ul class="values-list">
            <li v-for="value in values" :key="value.dateFormatted">
                {{ value.dateFormatted }} - {{ value.temperatureC }} - {{ value.summary }}
            </li>
        </ul>
        <button @click="onTryPost">Try POST action</button>
    </div>
</template>

<script>
    import NavBar from "@/Components/NavBar.vue";
    import { store } from "../../store.js";

    export default {
        name: "SampleApi",
        layout: NavBar,
        components: {
                NavBar
        },
        props: {
            msg: String,
            msgShare1: String,
            msgShare2: String
        },
    
        data() {
            return {
                values: []
            };
        },
        created() {
            store.setCurrentPageAction("Home/SampleApi");

            // Send request to the ASP.NET Core application.
            // No need to specify the host:port since it all runs from the same location
            return fetch("/api/SampleData/WeatherForecasts")
                .then(res => res.json())
                .then(data => { this.values = data });
        },
        methods: {
            onTryPost() {
                return fetch("/api/SampleData", { method: "POST" })
                    .then(res => res.json())
                    .then(data => { this.values = data });
            }
        }
    };
</script>

<style scoped>
    #SampleApi {
    font-family: 'Avenir', Helvetica, Arial, sans-serif;
    -webkit-font-smoothing: antialiased;
    -moz-osx-font-smoothing: grayscale;
    text-align: center;
    color: #2c3e50;
  }

    .values-list {
        list-style: none;
    }
</style>
