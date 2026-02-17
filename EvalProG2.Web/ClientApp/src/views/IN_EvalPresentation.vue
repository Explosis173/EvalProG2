<script setup lang="ts">
//---imports---
import { ref } from 'vue';

//---variables---
const goalorientedvalue = ref(null);
const visualisationvalue = ref(null);
const speechvalue = ref(null);
const technicalvalue = ref(null);
const termsvalue = ref(null);
const argumentationvalue = ref(null);
const thematicvalue = ref(null);
const structurecommentvalue = ref(null);
const presentationcommentvalue = ref(null);
const communicationcommentvalue = ref(null);
const conversationcommentvalue = ref(null);

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
                    <h1 class="bold">Bewertung des Fachgesprächs von Prüfling [nummer], [name]</h1>
                </div>
            </section>
            <section>
                <form id="evalPresentationForm" v-on:submit.prevent="">
                    <h1>Bewertungskriterien / Präsentation</h1>
                        <h2 class="bold">Aufbau und inhaltliche Struktur</h2>
                            <div class="form-row">
                                <label class="bigfont " for="goaloriented">Zielorientierung, Logik, sachliche und zeitliche Gliederung: </label>
                                <InputText v-model="goalorientedvalue" type="text" id="goaloriented" class="field" placeholder="0 - 10 Punkte"></InputText>
                            </div>
                            <div class="form-row">
                                <Textarea v-model="structurecommentvalue" type="text" id="structure" class="field" placeholder="Kommentar zum Aufbau und inhaltlicher Struktur"></Textarea>
                            </div>
                        <h2 class="bold">Präsentationstechnik</h2>
                            <div class="form-row">
                                <label class="bigfont " for="visualisation">Medieneinsatz, Visualisierung, Körpersprache: </label>
                                <InputText v-model="visualisationvalue" type="text" id="visualisation" class="field" placeholder="0 - 10 Punkte"></InputText>
                            </div>
                            <div class="form-row">
                                <Textarea v-model="presentationcommentvalue" type="text" id="presentation" class="field" placeholder="Kommentar zur Präsentationstechnik"></Textarea>
                            </div>
                        <h2 class="bold">Kommunikative Kompetenz</h2>
                            <div class="form-row">
                                <label class="bigfont " for="speech">Sprachstil, Ausdrucksweise, Satzbau, Überzeugungsfähigkeit: </label>
                                <InputText v-model="speechvalue" type="text" id="speech" class="field" placeholder="0 - 10 Punkte"></InputText>
                            </div>
                            <div class="form-row">
                                <Textarea v-model="communicationcommentvalue" type="text" id="communication" class="field" placeholder="Kommentar zur Kommunikativen Kompetenz"></Textarea>
                            </div>
                    <h1>Bewertungskriterien / Fachgespräch</h1>
                        <h2 class="bold">Vollständigkeit und fachliche Kompetenz</h2>
                            <div class="form-row">
                                <label class="bigfont" for="technical">Fachhintergrund: </label>
                                <InputText v-model="technicalvalue" type="text" id="technical" class="field" placeholder="0 - 10 Punkte"></InputText>
                            </div>
                            <div class="form-row">
                                <label class="bigfont" for="terms">Verwendung von Fachbegriffen: </label>
                                <InputText v-model="termsvalue" type="text" id="terms" class="field" placeholder="0 - 10 Punkte"></InputText>
                            </div>
                            <div class="form-row">
                                <label class="bigfont" for="argumentation">Argumentation: </label>
                                <InputText v-model="argumentationvalue" type="text" id="argumentation" class="field" placeholder="0 - 10 Punkte"></InputText>
                            </div>
                            <div class="form-row">
                                <label class="bigfont" for="thematic">thematische Durchdringung: </label>
                                <InputText v-model="thematicvalue" type="text" id="thematic" class="field" placeholder="0 - 10 Punkte"></InputText>
                            </div>
                            <div class="form-row">
                                <Textarea v-model="conversationcommentvalue" type="text" id="conversation" class="field" placeholder="Kommentar zur Vollständigkeit und fachlichen Kompetenz"></Textarea>
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