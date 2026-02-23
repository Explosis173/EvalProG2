<script setup lang="ts">
//---imports---
import { ref } from 'vue';

//---variables---
const date = ref(null)
const titlevalue = ref(null)
const jobvalue = ref(null)

const isDisabled = ref(true); // felder werden nicht mehr eingebbar
const appear = ref(false); // Buttons erscheinen

//---functions---
const backup = {
    name: ref(null),
    company: ref(null),
    responsible: ref(null),
    topic: ref(null)
};

const enableEditing = () => {
    backup.name.value = date.value;
    backup.company.value = titlevalue.value;
    backup.responsible.value = jobvalue.value;

    isDisabled.value = false;
    appear.value = true;
};


const save = () => {
    isDisabled.value = true;
    appear.value = false;
};

const cancel = () => {
    date.value = backup.name.value;
    titlevalue.value = backup.company.value;
    jobvalue.value = backup.responsible.value;

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
                    <h1 class="bold">Prüfungsausschuss ansehen</h1>
                </div>
            </section>
            <section>
                <form id="examinerForm" v-on:submit.prevent="">
                    <div class="form-row">
                        <label class="bigfont bold" for="title">Titel des Ausschusses: </label>
                        <InputText v-model="titlevalue" type="text" id="title" class="field" placeholder="Datenbankwert" :disabled="isDisabled"></InputText>
                    </div>
                    <div class="form-row">
                        <label class="bigfont bold" for="job">Zu bewertender Ausbildungsberuf: </label> 
                        <InputText v-model="jobvalue" type="text" id="job" class="field" placeholder="Datenbankwert" :disabled="isDisabled"></InputText>
                        
                    </div>
                    <div class="form-row">
                        <label class="bigfont bold" for="examDate">Datum des Ausschusses: </label>
                        <DatePicker v-model="date" dateFormat="dd/mm/yyyy" id="examDate" class="field" placeholder="Datenbankwert" fluid :disabled="isDisabled"/>
                    </div>
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


<style>

</style>