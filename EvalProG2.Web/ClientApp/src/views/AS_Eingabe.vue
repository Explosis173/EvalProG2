<script setup lang="ts">
//---imports---
import { ref } from 'vue';

//---variables---
const items = [
  {
    image: 'stadt-regensburg.png',
    title: 'EvalPro',
    subtitle: 'Das professionelle Bewertungstool für die mündliche IHK-Prüfung'
  }
];

const date = ref(null)
const titlevalue = ref(null)
const jobvalue = ref(null)

//---functions---

</script>


<!--main code-->
<template #content>
    <div class="page">
        <header>
          <!--<DataTable :value="items">
                <Column>
                    <template #body="slotProps">
                        <div class="banner">
                            <img src="../assets/stadt-regensburg.png" alt="Logo der Stadt Regensburg" class="rgb_logo"/>
                            <div>
                                <h1 class="bold">{{ slotProps.data.title }}</h1>
                                <h2 class="italics">{{ slotProps.data.subtitle }}</h2>
                            </div>
                        </div>
                    </template>
                </Column>
            </DataTable>-->
        </header>
        
        <main>
            <section>
                <form class="form" id="examinerForm" v-on:submit.prevent="">
                    <div>
                        <label class="bold" for="title">Titel des Ausschusses: 
                            <InputText v-model="titlevalue" type="text" id="title" class="inputfield" placeholder="Titel"></InputText>
                        </label>
                    </div>
                    <div>
                        <label class="bold" for="job">Zu bewertender Ausbildungsberuf: 
                            <InputText v-model="jobvalue" type="text" id="job" class="inputfield" placeholder="Ausbildungsberuf"></InputText>
                        </label>
                    </div>
                    <div>
                        <label class="bold" for="examDay">Datum des Ausschusses: 
                            <DatePicker v-model="date" dateFormat="dd/mm/yyyy" id="examdate" class="inputfield" placeholder="Datum"/>
                        </label>
                    </div>
                    <Button type="submit" label="Anlegen" icon="pi pi-check" iconPos="right" severity="danger" raised/>
                </form>
            </section>
        </main>

        <footer>
            <!--<section>Impressum goes here</section>-->
        </footer>
    </div>
</template>


<style>
/*--- css for <> ---*/
    html, body{
        height: 100%;
        margin: 0;
    }

    main{
        margin-top: 5%;
        margin-bottom: 5%;
        display:flex;
        justify-content: center; 
        align-items: center;
        flex: 1;
    }

    footer{
        margin-top: auto;
        display: flex;
        justify-content: flex-end;
        background-color: #EDEDED;
        padding: 8px 16px;
    }

    label{
        display: flex;
        flex-direction: row;
        justify-content: flex-end;
        text-align: right;
        font-size: 1.5rem;  
    }

/*--- css for classes ---*/
    .banner{
        display: flex; 
        align-items: center; 
        justify-content: start; 
        gap: 1rem; 
        color: red; 
        background-color: #EDEDED;
        font-size: 1rem;
    }

    .page{
        min-height: 100vh;
        display: flex;
        flex-direction: column;
    }

    .rgb_logo{
        width: 15%;
        height: auto;
        padding: 0.5cm;
    }

    .form {
        display: flex;
        flex-direction: column; 
        gap: 20px;            
    }

        .inputfield{
        flex: 0 0 200px;
        margin-left: 10px;
    }

    .p-datatable-thead > tr > th, .p-datatable-tbody > tr > td {
        padding: 0 !important;
    }


    /*zeichenformatierung */
    .bold{
        font-weight: bold
    }
    .italics{
        font-style: italic;
    }

</style>

/*

notes:
+.+.+.+
-find way to adjust Button

*/