<script setup lang="ts">
//---imports---
import { ref } from 'vue';

//---variables---
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
const designcommentvalue = ref(null);
const contentcommentvalue = ref(null);
const opticcommentvalue = ref(null);
const goalcommentvalue = ref(null);
const customerdoccommentvalue = ref(null);


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
            <section class="siteHeadline">
                <div>
                    <h1 class="bold">Bewertung der Projektdokumentation von Prüfling [nummer], [name]</h1>
                </div>
            </section>
            <section>
                <form id="evalDocumentationForm" v-on:submit.prevent="">
                    <h2 class="bold">Gesamtgestaltung</h2>
                    
                        <div class="form-row">
                            <label class="bigfont" for="formal">formale Gestaltung: </label>
                            <InputText v-model="formalvalue" type="text" id="formal" class="field" placeholder="0 - 10 Punkte"></InputText>
                        </div>
                        <div class="form-row">
                            <label class="bigfont" for="sprachlich">sprachliche Gestaltung: </label>
                            <InputText v-model="langvalue" type="text" id="sprachlich" class="field" placeholder="0 - 10 Punkte"></InputText>
                        </div>
                        <div class="form-row">
                            <Textarea v-model="designcommentvalue" type="text" id="design" class="field" placeholder="Kommentar zur Gesamtgestaltung"></Textarea>
                        </div>
                    <h2 class="bold">Inhaltsübersicht</h2>
                        <div class="form-row">
                            <label class="bigfont" for="completion">Vollständigkeit: </label>
                            <InputText v-model="completionvalue" type="text" id="completion" class="field" placeholder="0 - 10 Punkte"></InputText>
                       </div>
                        <div class="form-row">
                            <Textarea v-model="contentcommentvalue" type="text" id="content" class="field" placeholder="Kommentar zur Inhaltsübersicht"></Textarea>
                        </div>
                    <h2 class="bold">Beschreibung/ Konkretisierung des Auftrags</h2>
                        <div class="form-row">
                            <label class=" bigfont" for="understanding">Verständlichkeit: </label>
                            <InputText v-model="understandingvalue" type="text" id="understanding" class="field" placeholder="0 - 10 Punkte"></InputText>
                            </div>
                        <div class="form-row">
                            <label class="bigfont" for="comprehension">Nachvollziehbarkeit des Auftrags: </label>
                            <InputText v-model="comprehensionvalue" type="text" id="comprehension" class="field" placeholder="0 - 10 Punkte"></InputText>
                            </div>
                        <div class="form-row">
                            <label class="bigfont" for="suitable">Angemessene Darstellung der relevanten Informationen: </label>
                            <InputText v-model="suitablevalue" type="text" id="suitable" class="field" placeholder="0 - 10 Punkte"></InputText>
                            </div>
                        <div class="form-row">
                            <Textarea v-model="opticcommentvalue" type="text" id="optic" class="field" placeholder="Kommentar zur Beschreibung/ Konkretisierung des Auftrags"></Textarea>
                        </div>
                    <h2 class="bold">Beschreibung der Prozessschritte und der erzielten Ergebnisse</h2>
                        <div class="form-row">
                            <label class="bigfont" for="plausibility">Plausibilität der Begründung der Prozeßschritte: </label>
                            <InputText v-model="plausibilityvalue" type="text" id="plausibility" class="field" placeholder="0 - 10 Punkte"></InputText>
                            </div>
                        <div class="form-row">
                            <label class="bigfont" for="goalorientation">Zielorientierung der Vorgehensweise und Nachvollziehbarkeit: </label>
                            <InputText v-model="goalorientationvalue" type="text" id="goalorientation" class="field" placeholder="0 - 10 Punkte"></InputText>
                            </div>
                        <div class="form-row">
                            <label class="bigfont" for="realistictime">Plausibilität des Zeitaufwandes für die Prozeßschritte: </label>
                            <InputText v-model="realistictimevalue" type="text" id="realistictime" class="field" placeholder="0 - 10 Punkte"></InputText>
                            </div>
                        <div class="form-row">
                            <Textarea v-model="goalcommentvalue" type="text" id="question" class="field" placeholder="Kommentar zur Beschreibung der Prozessschritte und der erzielten Ergebnisse"></Textarea>
                        </div>
                    <h2 class="bold">Kundendokumentation/ Produktdokumentation</h2>
                        <div class="form-row">
                            <label class="bigfont" for="customeroriented">in der Kundenorientierung dem Auftrag / Teilauftrag angemessen: </label>
                            <InputText v-model="customerorientedvalue" type="text" id="customeroriented" class="field" placeholder="0 - 10 Punkte"></InputText>
                            </div>
                        <div class="form-row">
                            <Textarea v-model="customerdoccommentvalue" type="text" id="question" class="field" placeholder="Kommentar zur Kundendokumentation/ Produktdokumentation"></Textarea>
                        </div>
                        <div class="submitbutton">
                            <Button type="submit" label="Absenden" icon="pi pi-check" iconPos="right" severity="danger" raised/>
                        </div>
                </form>
            </section>
        </main>

        <footer>
            <!--<section>Impressum goes here</section>-->
        </footer>
    </div>
</template>