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

const namevalue = ref(null);
const companyvalue = ref(null);
const responsiblevalue = ref(null);
const topicvalue = ref(null);

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
                    <h1 class="bold">Prüfling anlegen für Prüfungsausschuss [Titel] am [Datum]</h1>
                </div>
            </section>
            <section>
                <form class="form" id="examinerForm" v-on:submit.prevent="">
                    <div>
                        <label class="bold" for="name">Name der zu bewertenden Person: 
                            <InputText v-model="namevalue" type="text" id="name" class="inputfield" placeholder="Name, Vorname"></InputText>
                        </label>
                    </div>
                    <div>
                        <label class="bold" for="company">Ausbildungsbetrieb: 
                            <InputText v-model="companyvalue" type="text" id="company" class="inputfield" placeholder="Ausbildungsbetrieb"></InputText>
                        </label>
                    </div>
                    <div>
                        <label class="bold" for="responsiblePerson">Ausbilder: 
                            <InputText v-model="responsiblevalue" type="text" id="responsiblePerson" class="inputfield" placeholder="Ausbilder"></InputText>
                        </label>
                    </div>
                    <div>
                        <label class="bold" for="topic">Thema der Abschlussarbeit: 
                            <InputText v-model="topicvalue" type="text" id="topic" class="inputfield" placeholder="Thema"></InputText>
                        </label>
                    </div>   
                    <Button type="submit" label="Anlegen" icon="pi pi-check" iconPos="right" severity="danger" raised/>
                </form>
            </section>
        </main>

        <footer>
            <section>Impressum goes here</section>
        </footer>
    </div>
</template>