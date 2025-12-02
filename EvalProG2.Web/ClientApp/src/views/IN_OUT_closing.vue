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
            <DataTable :value="items">
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
            </DataTable>
        </header>
        
        <main>
            <section class="siteHeadline">
                <div>
                    <h1 class="bold">Abschließende Bewertung von Prüfling [nummer], [name]</h1>
                </div>
            </section>
            <section>
                <form class="form" id="examinerForm" v-on:submit.prevent="">
                    <div>
                        <label class="bold" for="title">[label]: 
                            <InputText v-model="titlevalue" type="text" id="title" class="inputfield" placeholder="Titel"></InputText>
                        </label>
                    </div>
                    <Button type="submit" label="Anlegen" icon="pi pi-check" iconPos="right" severity="danger" raised/>
                </form>
            </section>
        </main>

        <footer>
            <section>Impressum goes here</section>
        </footer>
    </div>
</template>