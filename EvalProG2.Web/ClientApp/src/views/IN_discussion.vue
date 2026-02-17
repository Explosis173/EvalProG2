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

const titlevalue = ref(null)

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
                    <h1 class="bold">Fragen für mündliche Prüfung, Prüfling [nummer], [name]</h1>
                    <h4>bevor diese oberfläche sinnvoll erstellt werden kann muss erst datenbankverbindung bestehen - Astrid</h4>
                </div>
            </section>
            <section>
                <form id="discussionForm" v-on:submit.prevent="">
                    <div class="form-row">
                        <label class="bigfont bold" for="title">[label]: </label>
                        <InputText v-model="titlevalue" type="text" id="title" class="field" placeholder="Titel"></InputText>                     
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