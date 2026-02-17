<script setup lang="ts">
    //---imports---
    import { ref } from 'vue';

    //---variables---
    const namevalue = ref(null);
    const companyvalue = ref(null);
    const responsiblevalue = ref(null);
    const topicvalue = ref(null);

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
                    <h1 class="bold">Prüfling ansehen</h1>
                </div>
            </section>
            <section>
                <form id="candidateForm" v-on:submit.prevent="">
                    <div class="form-row">
                        <label class="bigfont bold" for="name">Name der zu bewertenden Person: </label>
                        <InputText v-model="namevalue" type="text" id="name" class="field" placeholder="Datenbankwert" :disabled="true"></InputText>
                    </div>
                    <div class="form-row">
                        <label class="bigfont bold" for="company">Ausbildungsbetrieb: </label>
                        <InputText v-model="companyvalue" type="text" id="company" class="field" placeholder="Datenbankwert" :disabled="true"></InputText>
                    </div>
                    <div class="form-row">
                        <label class=" bigfont bold" for="responsiblePerson">Ausbilder: </label>
                        <InputText v-model="responsiblevalue" type="text" id="responsiblePerson" class="field" placeholder="Datenbankwert" :disabled="true"></InputText>
                    </div>
                    <div class="form-row">
                        <label class="bigfont bold" for="topic">Thema der Abschlussarbeit: </label>
                        <InputText v-model="topicvalue" type="text" id="topic" class="field" placeholder="TDatenbankwerta" :disabled="true"></InputText>
                    </div>
                    <div class="submitbutton">
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