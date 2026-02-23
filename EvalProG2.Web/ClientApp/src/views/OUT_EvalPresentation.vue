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



const isDisabled = ref(true); // felder werden nicht mehr eingebbar
const appear = ref(false); // Buttons erscheinen

const backup = {
    goaloriented: ref(null),
    visualisation: ref(null),
    speech: ref(null),
    technical: ref(null),
    terms: ref(null),
    argumentation: ref(null),
    thematic: ref(null),
    structurecomment: ref(null),
    presentationcomment: ref(null),
    communicationcomment: ref(null),
    conversationcomment: ref(null),
};


//---functions---
const enableEditing = () => {
    backup.goaloriented.value = goalorientedvalue.value;
    backup.visualisation.value = visualisationvalue.value;
    backup.speech.value = speechvalue.value;
    backup.technical.value = technicalvalue.value;
    backup.terms.value = termsvalue.value;
    backup.argumentation.value = argumentationvalue.value;
    backup.thematic.value = thematicvalue.value;
    backup.structurecomment.value = structurecommentvalue.value;
    backup.presentationcomment.value = presentationcommentvalue.value;
    backup.communicationcomment.value = communicationcommentvalue.value;
    backup.conversationcomment.value = conversationcommentvalue.value;

    isDisabled.value = false;
    appear.value = true;
};


const save = () => {
    isDisabled.value = true;
    appear.value = false;
};

const cancel = () => {
    goalorientedvalue.value = backup.goaloriented.value;
    visualisationvalue.value = backup.visualisation.value;
    speechvalue.value = backup.speech.value;
    technicalvalue.value = backup.technical.value;
    termsvalue.value = backup.terms.value;
    argumentationvalue.value = backup.argumentation.value;
    thematicvalue.value = backup.thematic.value;
    structurecommentvalue.value = backup.structurecomment.value;
    presentationcommentvalue.value = backup.presentationcomment.value;
    communicationcommentvalue.value = backup.communicationcomment.value;
    conversationcommentvalue.value = backup.conversationcomment.value;


    isDisabled.value = true;
    appear.value = false;
};
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
                                <InputText v-model="goalorientedvalue" type="text" id="goaloriented" class="field" placeholder="Datenbankwert" :disabled="isDisabled"></InputText>
                            </div>
                            <div class="form-row">
                                <Textarea v-model="structurecommentvalue" type="text" id="structure" class="field" placeholder="Datenbankwert" :disabled="isDisabled"></Textarea>
                            </div>
                        <h2 class="bold">Präsentationstechnik</h2>
                            <div class="form-row">
                                <label class="bigfont " for="visualisation">Medieneinsatz, Visualisierung, Körpersprache: </label>
                                <InputText v-model="visualisationvalue" type="text" id="visualisation" class="field" placeholder="Datenbankwert" :disabled="isDisabled"></InputText>
                            </div>
                            <div class="form-row">
                                <Textarea v-model="presentationcommentvalue" type="text" id="presentation" class="field" placeholder="Datenbankwert" :disabled="isDisabled"></Textarea>
                            </div>
                        <h2 class="bold">Kommunikative Kompetenz</h2>
                            <div class="form-row">
                                <label class="bigfont " for="speech">Sprachstil, Ausdrucksweise, Satzbau, Überzeugungsfähigkeit: </label>
                                <InputText v-model="speechvalue" type="text" id="speech" class="field" placeholder="Datenbankwert" :disabled="isDisabled"></InputText>
                            </div>
                            <div class="form-row">
                                <Textarea v-model="communicationcommentvalue" type="text" id="communication" class="field" placeholder="Datenbankwert" :disabled="isDisabled"></Textarea>
                            </div>
                    <h1>Bewertungskriterien / Fachgespräch</h1>
                        <h2 class="bold">Vollständigkeit und fachliche Kompetenz</h2>
                            <div class="form-row">
                                <label class="bigfont" for="technical">Fachhintergrund: </label>
                                <InputText v-model="technicalvalue" type="text" id="technical" class="field" placeholder="Datenbankwert" :disabled="isDisabled"></InputText>
                            </div>
                            <div class="form-row">
                                <label class="bigfont" for="terms">Verwendung von Fachbegriffen: </label>
                                <InputText v-model="termsvalue" type="text" id="terms" class="field" placeholder="Datenbankwert" :disabled="isDisabled"></InputText>
                            </div>
                            <div class="form-row">
                                <label class="bigfont" for="argumentation">Argumentation: </label>
                                <InputText v-model="argumentationvalue" type="text" id="argumentation" class="field" placeholder="Datenbankwert" :disabled="isDisabled"></InputText>
                            </div>
                            <div class="form-row">
                                <label class="bigfont" for="thematic">thematische Durchdringung: </label>
                                <InputText v-model="thematicvalue" type="text" id="thematic" class="field" placeholder="Datenbankwert" :disabled="isDisabled"></InputText>
                            </div>
                            <div class="form-row">
                                <Textarea v-model="conversationcommentvalue" type="text" id="conversation" class="field" placeholder="Datenbankwert" :disabled="isDisabled"></Textarea>
                            </div>
                    <!-- <div class="submitbutton">
                        <Button type="submit" label="Absenden" icon="pi pi-check" iconPos="right" severity="danger" raised/>
                    </div> -->
                      <div class="doButton">

                    <router-link to="./OUT_admin">
                    <Button label="Zurück" class="doButton" severity="danger" raised/>
                    </router-link>
                    
                        <Button label="Bearbeiten"
                                class="doButton"
                                icon="pi pi-pen-to-square"
                                iconPos="right"
                                severity="danger"
                                raised
                                @click="enableEditing" />
                    

                        </div>
                    <div class="form-row doButton">
                        <Button type="submit" label="Speichern" icon="pi pi-check" iconPos="right"
                                severity="success" v-show="appear" raised @click="save" />
                        <Button type="submit" label="Verwerfen" icon="pi pi-times" iconPos="right"
                                severity="danger" v-show="appear" raised @click="cancel"/>
                    </div>

                </form>
            </section>
        </main>

        <footer>
            <!--<section>Impressum goes here</section>-->
        </footer>
    </div>
</template>