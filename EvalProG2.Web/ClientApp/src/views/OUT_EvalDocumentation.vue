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


const isDisabled = ref(true); // felder werden nicht mehr eingebbar
const appear = ref(false); // Buttons erscheinen

const backup = {
    formal: ref(null),
    lang: ref(null),
    completion: ref(null),
    understanding: ref(null),
    comprehension: ref(null),
    suitable: ref(null),
    plausibility: ref(null),
    goalorientation: ref(null),
    realistictime: ref(null),
    customeroriented: ref(null),
    designcomment: ref(null),
    contentcomment: ref(null),
    opticcomment: ref(null),
    goalcomment: ref(null),
    customerdoccomment: ref(null)
};

//---functions---
const enableEditing = () => {
    backup.formal.value = formalvalue.value;
    backup.lang.value = langvalue.value;
    backup.completion.value = completionvalue.value;
    backup.understanding.value = understandingvalue.value;
    backup.comprehension.value = formalvalue.value;
    backup.suitable.value = suitablevalue.value;
    backup.plausibility.value = plausibilityvalue.value;
    backup.goalorientation.value = goalorientationvalue.value;
    backup.realistictime.value = realistictimevalue.value;
    backup.customeroriented.value = customerorientedvalue.value;
    backup.designcomment.value = designcommentvalue.value;
    backup.contentcomment.value = contentcommentvalue.value;
    backup.opticcomment.value = opticcommentvalue.value;
    backup.goalcomment.value = goalcommentvalue.value;
    backup.customerdoccomment.value = customerdoccommentvalue.value;


    isDisabled.value = false;
    appear.value = true;
};


const save = () => {
    isDisabled.value = true;
    appear.value = false;
};

const cancel = () => {
    formalvalue.value = backup.formal.value;
    langvalue.value = backup.lang.value;
    completionvalue.value = backup.completion.value;
    understandingvalue.value = backup.understanding.value;
    comprehensionvalue.value = backup.comprehension.value;
    suitablevalue.value = backup.suitable.value;
    plausibilityvalue.value = backup.plausibility.value;
    goalorientationvalue.value = backup.goalorientation.value;
    realistictimevalue.value = backup.realistictime.value;
    customerorientedvalue.value = backup.customeroriented.value;
    designcommentvalue.value = backup.designcomment.value;
    contentcommentvalue.value = backup.contentcomment.value;
    opticcommentvalue.value = backup.opticcomment.value;
    goalcommentvalue.value = backup.goalcomment.value;
    customerdoccommentvalue.value = backup.customerdoccomment.value;

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
                    <h1 class="bold">Bewertung der Projektdokumentation von Prüfling [nummer], [name]</h1>
                </div>
            </section>
            <section>
                <form id="evalDocumentationForm" v-on:submit.prevent="">
                    <h2 class="bold">Gesamtgestaltung</h2>
                    
                        <div class="form-row">
                            <label class="bigfont" for="formal">formale Gestaltung: </label>
                            <InputText v-model="formalvalue" type="text" id="formal" class="field" placeholder="Datenbankwert" :disabled="isDisabled"></InputText>
                        </div>
                        <div class="form-row">
                            <label class="bigfont" for="sprachlich">sprachliche Gestaltung: </label>
                            <InputText v-model="langvalue" type="text" id="sprachlich" class="field" placeholder="Datenbankwert" :disabled="isDisabled"></InputText>
                        </div>
                        <div class="form-row">
                            <Textarea v-model="designcommentvalue" type="text" id="design" class="field" placeholder="Datenbankwert" :disabled="isDisabled"></Textarea>
                        </div>
                    <h2 class="bold">Inhaltsübersicht</h2>
                        <div class="form-row">
                            <label class="bigfont" for="completion">Vollständigkeit: </label>
                            <InputText v-model="completionvalue" type="text" id="completion" class="field" placeholder="Datenbankwert" :disabled="isDisabled"></InputText>
                       </div>
                        <div class="form-row">
                            <Textarea v-model="contentcommentvalue" type="text" id="content" class="field" placeholder="Datenbankwert" :disabled="isDisabled"></Textarea>
                        </div>
                    <h2 class="bold">Beschreibung/ Konkretisierung des Auftrags</h2>
                        <div class="form-row">
                            <label class=" bigfont" for="understanding">Verständlichkeit: </label>
                            <InputText v-model="understandingvalue" type="text" id="understanding" class="field" placeholder="Datenbankwert" :disabled="isDisabled"></InputText>
                            </div>
                        <div class="form-row">
                            <label class="bigfont" for="comprehension">Nachvollziehbarkeit des Auftrags: </label>
                            <InputText v-model="comprehensionvalue" type="text" id="comprehension" class="field" placeholder="Datenbankwert" :disabled="isDisabled"></InputText>
                            </div>
                        <div class="form-row">
                            <label class="bigfont" for="suitable">Angemessene Darstellung der relevanten Informationen: </label>
                            <InputText v-model="suitablevalue" type="text" id="suitable" class="field" placeholder="Datenbankwert" :disabled="isDisabled"></InputText>
                            </div>
                        <div class="form-row">
                            <Textarea v-model="opticcommentvalue" type="text" id="optic" class="field" placeholder="Datenbankwert" :disabled="isDisabled"></Textarea>
                        </div>
                    <h2 class="bold">Beschreibung der Prozessschritte und der erzielten Ergebnisse</h2>
                        <div class="form-row">
                            <label class="bigfont" for="plausibility">Plausibilität der Begründung der Prozeßschritte: </label>
                            <InputText v-model="plausibilityvalue" type="text" id="plausibility" class="field" placeholder="Datenbankwert" :disabled="isDisabled"></InputText>
                            </div>
                        <div class="form-row">
                            <label class="bigfont" for="goalorientation">Zielorientierung der Vorgehensweise und Nachvollziehbarkeit: </label>
                            <InputText v-model="goalorientationvalue" type="text" id="goalorientation" class="field" placeholder="Datenbankwert" :disabled="isDisabled"></InputText>
                            </div>
                        <div class="form-row">
                            <label class="bigfont" for="realistictime">Plausibilität des Zeitaufwandes für die Prozeßschritte: </label>
                            <InputText v-model="realistictimevalue" type="text" id="realistictime" class="field" placeholder="Datenbankwert" :disabled="isDisabled"></InputText>
                            </div>
                        <div class="form-row">
                            <Textarea v-model="goalcommentvalue" type="text" id="question" class="field" placeholder="Datenbankwert" :disabled="isDisabled"></Textarea>
                        </div>
                    <h2 class="bold">Kundendokumentation/ Produktdokumentation</h2>
                        <div class="form-row">
                            <label class="bigfont" for="customeroriented">in der Kundenorientierung dem Auftrag / Teilauftrag angemessen: </label>
                            <InputText v-model="customerorientedvalue" type="text" id="customeroriented" class="field" placeholder="Datenbankwert" :disabled="isDisabled"></InputText>
                            </div>
                        <div class="form-row">
                            <Textarea v-model="customerdoccommentvalue" type="text" id="question" class="field" placeholder="Datenbankwert" :disabled="isDisabled"></Textarea>
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