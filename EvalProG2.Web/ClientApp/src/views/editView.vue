<script setup lang="ts">
//---imports---

//---variables---

//---functions---

</script>

<template>
  <div class="container2">
    
  </div>
  
  <div class="container"><br><br>
    <h2>Was wollen Sie überprüfen?</h2><br></br>
    <router-link to="/eval_doc"><button type="button" class="PD">Projekt</button></router-link>
    <router-link to="/eval_pres"><button type="button" class="FG">Fachgespräch</button></router-link><br><br><br><br> 
    <router-link to="/closingremarks"><button type="button" class="GE">Gesamtergebnis</button></router-link>
    <router-link to="/discussion"><button type="button" class="MP">Mündliche Prüfung</button></router-link><br><br><br><br>
    <router-link to="/"><button type="button" class="back">Zurück</button></router-link>
  </div>
</template>
 
<!--
<style scoped>
  /* Basic button styling */
  button {
      padding: 20px 20px;
      font-size: 25px;
      border: none;
      border-radius: 15px;
      cursor: pointer;
  }

  .container {
      text-align: center;
  }  

  /* Different button styles */
  .PD {
/*      margin-top: 30px;*/
      background-color: red;
      color: white;
          border-radius: 20px;
    border: 4px double #cccccc;
  }

  .PP {
    margin-left: 20px;
      background-color: red;
      color: white;
          border-radius: 20px;
    border: 4px double #cccccc;
  }

  .FG {
    margin-left: 20px;
      background-color: red;
      color: white;
          border-radius: 20px;
    border: 4px double #cccccc;
  }

  .GE {
    margin-left: 20px;
      background-color: red;
      color: white;
          border-radius: 20px;
    border: 4px double #cccccc;
  }

  .MP {
    margin-left: 20px;
      background-color: red;
      color: white;
          border-radius: 20px;
    border: 4px double #cccccc;
  }

    .back {
    margin-left: 20px;
      background-color: red;
      color: white;
          border-radius: 20px;
    border: 4px double #cccccc;
  }
</style>
-->
