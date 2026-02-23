<script setup lang="ts">
//---imports---
import { ref } from 'vue';

//---variables---


const isDisabled = ref(true); // felder werden nicht mehr eingebbar
const appear = ref(false); // Buttons erscheinen

//---functions---
const enableEditing = () => {
    isDisabled.value = false;
    appear.value = true;
};


const save = () => {
    isDisabled.value = true;
    appear.value = false;
};

const cancel = () => {
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
                    <h1 class="bold">Fragen für mündliche Prüfung, Prüfling [nummer], [name]</h1>
                    <h4>bevor diese oberfläche sinnvoll erstellt werden kann muss erst datenbankverbindung bestehen - Astrid</h4>
                </div>
            </section>
            <section>
                <form id="discussionForm" v-on:submit.prevent="">
                    <div class="form-row">
                        <label class="bigfont bold" for="title">[label]: </label>
                        <Text class="field">bevor hier was sinnvolles stehen kann muss datenbankverbindung bestehen</Text>                    
                    </div>
                    <!-- <div class="submitbutton">
                        <Button type="submit" label="Absenden" icon="pi pi-check" iconPos="right" severity="danger" raised/>
                    </div>        -->
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