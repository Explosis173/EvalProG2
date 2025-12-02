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
            <DataTable :value="items">
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
            </DataTable>
        </header>
        
        <main>
            <section class="siteHeadline">
                <div>
                    <h1 class="bold">Neuen Prüfungsausschuss anlegen</h1>
                </div>
            </section>
            <section>
                <form id="examinerForm" v-on:submit.prevent="">
                    <div class="form-row">
                        <label class="bigfont bold" for="title">Titel des Ausschusses: </label>
                        <InputText v-model="titlevalue" type="text" id="title" class="field" placeholder="Titel"></InputText>
                    </div>
                    <div class="form-row">
                        <label class="bigfont bold" for="job">Zu bewertender Ausbildungsberuf: </label> 
                        <InputText v-model="jobvalue" type="text" id="job" class="field" placeholder="Ausbildungsberuf"></InputText>
                        
                    </div>
                    <div class="form-row">
                        <label class="bigfont bold" for="examDate">Datum des Ausschusses: </label>
                        <DatePicker v-model="date" dateFormat="dd/mm/yyyy" id="examDate" class="field" placeholder="Datum" fluid/>
                    </div>
                    <div class="submitbutton biggerfont">
                        <Button type="submit" label="Anlegen" icon="pi pi-check" iconPos="right" severity="danger" raised/>
                    </div>
                </form>
            </section>
        </main>

        <footer>
            <section>Impressum goes here</section>
        </footer>
    </div>
</template>


<style>

</style>