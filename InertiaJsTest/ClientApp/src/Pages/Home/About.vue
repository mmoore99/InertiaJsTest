<template>
    <div class="about">
        <h1>This is an about page</h1>
        <h2>{{ msg }}</h2>
    </div>
</template>


<script>

    // @ is an alias to /src
    //import HelloWorld from '@/components/HelloWorld.vue'
    import NavBar from "@/Components/NavBar.vue";

    const EventIds = {
            newPageLoaded: "new-page-loaded",
    };

    export default {
        name: "About",
        layout: NavBar,
        props: {
            msg: String
        },
        components: {

        },
        data() {
            return {

            };
        },
        created() {
            this.$root.$emit(EventIds.newPageLoaded, this.$options.name);
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
</style>
