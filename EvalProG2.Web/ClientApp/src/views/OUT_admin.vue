<script setup lang="ts">
    //---imports---
    import { ref } from 'vue';

    //---variables---
    
    const selectedExaminer = ref(null);
    const selectedCandidate = ref(null);
    const cities = ref([
        { name: 'New York', code: 'NY' },
        { name: 'Rome', code: 'RM' },
        { name: 'London', code: 'LDN' },
        { name: 'Istanbul', code: 'IST' },
        { name: 'Paris', code: 'PRS' }
    ]);

    //---functions---

</script>


<!--main code-->
<template #content>
    <div class="page">
        <header>

        </header>
        
        <main>
            <section class="siteHeadline">
                <div>
                    <h1 class="bold">Auswahl der anzuzeigenden Daten</h1>
                </div>
            </section>
            <section>
                <div class="show-row">
                    <h2 class="bold">Datengrundlage</h2>
                </div>
                <div class="show-row">
                    <label class="bigfont bold" for="name">Prüfungsausschuss: </label>
                    <Select v-model="selectedExaminer" :options="cities" optionLabel="name" placeholder="Prüfungsausschuss wählen" class="dropdown" />
                    <router-link to="/OUT_Examiner">
                        <Button label="Bearbeiten" class="doButton" label:edit icon="pi pi-pen-to-square" iconPos="right" severity="danger" raised/>
                    </router-link>
                </div> 
                <div class="show-row">
                    <label class="bigfont bold" for="name">Prüfling: </label>
                    <Select v-model="selectedCandidate" :options="cities" optionLabel="name" placeholder="Prüfling wählen" class="dropdown" />
                    <router-link to="/OUT_candidate">
                        <Button label="Bearbeiten" class="doButton" icon="pi pi-pen-to-square" iconPos="right" severity="danger" raised/>
                    </router-link>
                </div>
            </section>
            <br>
            <section>
                <div class="show-row">
                    <h2 class="bold">Anzeigemöglichkeiten</h2>
                </div>
                <div class="submitbutton">
                    <router-link to="/OUT_EvalDocumentation">
                    <Button label="Dokumentationsbewertung" class="showMeButton" icon="pi pi-book" iconPos="left" severity="danger" raised/>
                    </router-link>
                    <router-link to="/OUT_EvalPresentation">
                    <Button label="Präsentationsbewertung" class="showMeButton" icon="pi pi-image" iconPos="left" severity="danger" raised/>
                    </router-link>
                    <router-link to="/OUT_Discussion">
                    <Button label="Projektverteidugung" class="showMeButton" icon="pi pi-user" iconPos="left" severity="danger" raised/>
                    </router-link>
                </div>
                <div class="submitbutton">
                    <router-link to="./">
                    <Button label="Zurück" class="showMeButton" severity="danger" raised/>
                    </router-link>
                    <router-link to="/closingremarks">
                    <Button label="Gesamtergebnis" class="showMeButton" severity="danger" raised/>
                    </router-link>
                </div>  
            
            </section>
        </main>

        <footer>
            <!--<section>Impressum goes here</section>-->
        </footer>
    </div>
</template>
