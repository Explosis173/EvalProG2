<script setup lang="ts">
    //---imports---
    import { ref } from 'vue';

    //---variables---
    const namevalue = ref(null);
    const companyvalue = ref(null);
    const responsiblevalue = ref(null);
    const topicvalue = ref(null);

    const isDisabled = ref(true); // felder werden nicht mehr eingebbar
    const appear = ref(false); // Buttons erscheinen

    //---functions---
// Steuert, ob die Felder gesperrt sind


// --- Backup-Werte für "Verwerfen" ---
const backup = {
    name: ref(null),
    company: ref(null),
    responsible: ref(null),
    topic: ref(null)
};


// Bearbeiten aktivieren
const enableEditing = () => {
    // aktuelle Werte sichern
    backup.name.value = namevalue.value;
    backup.company.value = companyvalue.value;
    backup.responsible.value = responsiblevalue.value;
    backup.topic.value = topicvalue.value;

    isDisabled.value = false;
    appear.value = true;
};

// Speichern
const save = () => {
    // nichts weiter nötig – die aktuellen Werte bleiben bestehen
    isDisabled.value = true;
    appear.value = false;
};

// Verwerfen
const cancel = () => {
    // alte Werte wiederherstellen
    namevalue.value = backup.name.value;
    companyvalue.value = backup.company.value;
    responsiblevalue.value = backup.responsible.value;
    topicvalue.value = backup.topic.value;

    isDisabled.value = true;
    appear.value = false;
};
</script>



<!--main code-->
<template #content>
    <div class="page">
        <main>
            <section>
                <form id="candidateForm" v-on:submit.prevent="">
                    <div class="form-row">
                        <label class="bigfont bold" for="name">Name der zu bewertenden Person: </label>
                        <InputText v-model="namevalue" type="text" id="name" class="field"
                                   placeholder="Datenbankwert" :disabled="isDisabled" />
                    </div>

                    <div class="form-row">
                        <label class="bigfont bold" for="company">Ausbildungsbetrieb: </label>
                        <InputText v-model="companyvalue" type="text" id="company" class="field"
                                   placeholder="Datenbankwert" :disabled="isDisabled" />
                    </div>

                    <div class="form-row">
                        <label class="bigfont bold" for="responsiblePerson">Ausbilder: </label>
                        <InputText v-model="responsiblevalue" type="text" id="responsiblePerson" class="field"
                                   placeholder="Datenbankwert" :disabled="isDisabled" />
                    </div>

                    <div class="form-row">
                        <label class="bigfont bold" for="topic">Thema der Abschlussarbeit: </label>
                        <InputText v-model="topicvalue" type="text" id="topic" class="field"
                                   placeholder="Datenbankwert" :disabled="isDisabled" />
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
                    <template>

</template>
                </form>
            </section>
        </main>
    </div>
</template>

