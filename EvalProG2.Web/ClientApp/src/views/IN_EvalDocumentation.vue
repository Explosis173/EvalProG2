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

const formalvalue = ref(null);
const langvalue = ref(null);
const completionvalue = ref(null);
const understandingvalue = ref(null);
const comprehensionvalue = ref(null);
const suitablevalue = ref(null);
const plausibilityvalue = ref(null);
const goalorientationvalue = ref(null);
const realistictimevalue = ref(null);
const customerorientedvalue = ref(null);

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
                    <h1 class="bold">Bewertung der Projektdokumentation von Prüfling [nummer], [name]</h1>
                </div>
            </section>
            <section>
                <form id="evalDocumentationForm" v-on:submit.prevent="">
                    <h2>Gesamtgestaltung</h2>
                        <div>
                        <label class="bold" for="formal">formale Gestaltung: 
                            <InputText v-model="formalvalue" type="text" id="formal" class="inputfield" placeholder="0 - 10 Punkte"></InputText>
                        </label>
                        </div>
                        <div>
                        <label class="bold" for="sprachlich">sprachliche Gestaltung: 
                            <InputText v-model="langvalue" type="text" id="sprachlich" class="inputfield" placeholder="0 - 10 Punkte"></InputText>
                        </label>
                        </div>
                    <h2>Inhaltsübersicht</h2>
                        <div>
                        <label class="bold" for="completion">Vollständigkeit: 
                            <InputText v-model="completionvalue" type="text" id="completion" class="inputfield" placeholder="0 - 10 Punkte"></InputText>
                        </label>
                        </div>
                    <h2>Beschreibung/ Konkretisierung des Auftrags</h2>
                        <div>
                            <label class="bold" for="understanding">Verständlichkeit: 
                                <InputText v-model="understandingvalue" type="text" id="understanding" class="inputfield" placeholder="0 - 10 Punkte"></InputText>
                            </label>
                        </div>
                        <div>
                            <label class="bold" for="comprehension">Nachvollziehbarkeit des Auftrags: 
                                <InputText v-model="comprehensionvalue" type="text" id="comprehension" class="inputfield" placeholder="0 - 10 Punkte"></InputText>
                            </label>
                        </div>
                        <div>
                            <label class="bold" for="suitable">Angemessene Darstellung der relevanten Informationen: 
                                <InputText v-model="suitablevalue" type="text" id="suitable" class="inputfield" placeholder="0 - 10 Punkte"></InputText>
                            </label>
                        </div>
                    <h2>Beschreibung der Prozessschritte und der erzielten Ergebnisse</h2>
                        <div>
                            <label class="bold" for="plausibility">Plausibilität der Begründung der Prozeßschritte: 
                                <InputText v-model="plausibilityvalue" type="text" id="plausibility" class="inputfield" placeholder="0 - 10 Punkte"></InputText>
                            </label>
                        </div>
                        <div>
                            <label class="bold" for="goalorientation">Zielorientierung der Vorgehensweise und Nachvollziehbarkeit: 
                                <InputText v-model="goalorientationvalue" type="text" id="goalorientation" class="inputfield" placeholder="0 - 10 Punkte"></InputText>
                            </label>
                        </div>
                                                <div>
                            <label class="bold" for="realistictime">Plausibilität des Zeitaufwandes für die Prozeßschritte: 
                                <InputText v-model="realistictimevalue" type="text" id="realistictime" class="inputfield" placeholder="0 - 10 Punkte"></InputText>
                            </label>
                        </div>
                    <h2>Kundendokumentation/ Produktdokumentation</h2>
                        <div>
                            <label class="bold" for="customeroriented">in der Kundenorientierung dem Auftrag / Teilauftrag angemessen: 
                                <InputText v-model="customerorientedvalue" type="text" id="customeroriented" class="inputfield" placeholder="0 - 10 Punkte"></InputText>
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