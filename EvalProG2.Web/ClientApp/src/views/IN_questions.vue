<script setup lang="ts">
//---imports---
import { ref } from 'vue';

//---variables---
const questionvalue = ref(null)

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
                    <h1 class="bold">Anlegen einer neuen Frage für die mündliche Prüfung</h1>
                </div>
            </section>
            <section>
                <form id="questionsForm" v-on:submit.prevent="">
                    <div class="form-row">
                        <label class="bigfont bold" for="question">Neue Frage: </label>
                        <Textarea v-model="questionvalue" type="text" id="question" class="field" placeholder="Fragentext"></Textarea>
                    </div>
                    <div class ="submitbutton">
                        <Button type="submit" label="Anlegen" icon="pi pi-check" iconPos="right" severity="danger" raised/>
                    </div>
                </form>
            </section>
        </main>

        <footer>
            <!--<section>Impressum goes here</section>-->
        </footer>
    </div>
</template>