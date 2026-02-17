<script setup lang="ts">
//import { RouterLink, RouterView } from 'vue-router'
//import HelloWorld from './components/HelloWorld.vue'

import DataTable from 'primevue/datatable';
import Column from 'primevue/column';
import Button from 'primevue/button';


const items = [
  {
    image: 'stadt-regensburg.png',
    title: 'EvalPro',
    subtitle: 'Das professionelle Bewertungstool für die mündliche IHK-Prüfung'
  }
];
</script>



<template #content>
    <head>

    </head>
        <header>
            <DataTable :value="items">
                <Column>
                <template #body="slotProps">
                    <div style="display: flex; align-items: center; gap: 1 rem;">
                        <img src="../stadt-regensburg.png" alt="Logo der Stadt Regensburg" class="rgb_logo"/>
                        <div>
                            <h1 class="bold">{{ slotProps.data.title }}</h1>
                            <h2 class="italics">{{ slotProps.data.subtitle }}</h2>
                        </div>
                    </div>
                </template>
                </Column>
            </DataTable>
        </header>
       <!-- <footer>
            <section>Impressum goes here</section>
        </footer>-->
<br><br><br>
  <RouterView />
</template>


<style scoped>
header{
        display: flex;
        justify-content: start;
        color: red;
        background-color: #EDEDED;
    }
    main{
        margin-top: 5%;
        margin-bottom: 5%;
        display:flex;
        align-self: center;
    }
    footer{
        display: flex;
        justify-content: end;
        background-color: #EDEDED;
    }

    .rgb_logo{
        width: 10%;
        height: auto;
        padding: 0.5cm;
    }


    main {
        display: flex;
        justify-content: center;
        align-items: center;
    }


    .form {
        display: flex;
        flex-direction: column;
        gap: 20px;              
    }

    .bold{
        font-weight: bold
    }
    .italics{
        font-style: italic;
    }

.logo {
  display: block;
  margin: 0 auto 2rem;
}

nav {
  width: 100%;
  font-size: 12px;
  text-align: center;
  margin-top: 2rem;
}

nav a.router-link-exact-active {
  color: var(--color-text);
}
nav a.router-link-exact-active:hover {
  background-color: transparent;
}

nav a {
  display: inline-block;
  padding: 0 1rem;
  border-left: 1px solid var(--color-border);
}

nav a:first-of-type {
  border: 0;
}

@media (min-width: 1024px) {
  header {
    display: flex;
    place-items: center;
    padding-right: calc(var(--section-gap) / 2);
  }

  .logo {
    margin: 0 2rem 0 0;
  }

  header .wrapper {
    display: flex;
    place-items: flex-start;
    flex-wrap: wrap;
  }

  nav {
    text-align: left;
    margin-left: -1rem;
    font-size: 1rem;

    padding: 1rem 0;
    margin-top: 1rem;
  }
}


</style>
