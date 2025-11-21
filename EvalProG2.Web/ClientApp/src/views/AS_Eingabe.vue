<script setup lang="ts">
//---imports---
import DataTable from 'primevue/datatable';
import Column from 'primevue/column';
import Button from 'primevue/button';
import 'primereact/resources/primereact.min.css';
import 'primeicons/primeicons.css';


//---variables---
const items = [
  {
    image: 'stadt-regensburg.png',
    title: 'EvalPro',
    subtitle: 'Das professionelle Bewertungstool für die mündliche IHK-Prüfung'
  }
];


//---functions---


</script>

<template #content>
    <head>

    </head>
    <body>
        <header>
            <DataTable :value="items">
                <Column>
                <template #body="slotProps">
                    <div style="display: flex; align-items: center; gap: 1rem;">
                        <img src="../assets/stadt-regensburg.png" alt="Logo der Stadt Regensburg" class="rgb_logo"/>
                        <div>
                            <h1>{{ slotProps.data.title }}</h1>
                            <h2>{{ slotProps.data.subtitle }}</h2>
                        </div>
                    </div>
                </template>
                </Column>
            </DataTable>
        </header>
        <main>
            <section>
                <form class="form" id="examinerForm" v-on:submit.prevent="">
                    <div><label for="title">Titel des Ausschusses: <input id="title" placeholder="Titel"></input></label></div>
                    <div><label for="job">Zu bewertender Ausbildungsberuf: <input  id="job" placeholder="Ausbildungsberuf"></input></label></div>
                    <div><label for="examDay">Datum des Ausschusses: <input id="examDay" placeholder="Datum"></input></label></div>
                    <Button label="Anlegen" icon="pi pi-check" iconPos="right" severity="danger" />
                </form>
            </section>
        </main>
        <footer>
            <section>Impressum goes here</section>
        </footer>
    </body>
</template>

<style>
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


    h1{
        font-weight: bold;
    }
    h2{
        font-style: italic;
    }

    label{
        font-weight: bold;
    }
</style>