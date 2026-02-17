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

const closingRemarkvalue = ref(null)

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
                    <h1 class="bold">Abschließende Bewertung von Prüfling [nummer], [name]</h1>
                </div>
            </section>
            <section>
                <form id="closingForm" v-on:submit.prevent="">
                    <div class="form-row">
                        <label class="big font bold" for="AP1">Bewertung AP 1: </label>
                        <Text class="field">0 - 100 Punkte</Text>
                    </div>
                    <div class="form-row">
                        <label class="big font bold" for="AP2">Bewertung AP 2: </label>
                        <Text class="field">0 - 100 Punkte</Text>
                    </div>
                    <div class="form-row">
                        <label class="big font bold" for="project">Bewertung Projektarbeit: </label>
                        <Text class="field">0 - 100 Punkte</Text>
                    </div>
                    <div class="form-row">
                        <label class="big font bold" for="presentation">Bewertung Präsentation und Fachgespräch: </label>
                        <Text class="field">0 - 100 Punkte</Text>
                    </div>
                    <h2 class="bold">Abschließende Bemerkung</h2>
                        <div class="form-row">
                        <Textarea v-model="closingRemarkvalue" type="text" id="closingRemark" class="field" placeholder="Kommentar"></Textarea>
                        </div>                                                            
                    <div class="submitbutton">
                        <Button type="submit" label="Berechnung der Endnote beginnen" icon="pi pi-check" iconPos="right" severity="danger" raised/>
                    </div>
                    
                </form>
            </section>
        </main>

        <footer>
            <!--<section>Impressum goes here</section>-->
        </footer>
    </div>
</template>