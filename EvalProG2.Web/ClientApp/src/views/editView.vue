<template>
  <div class="container2">
    
  </div>
  
  <div class="container"><br><br><br><br><br><br>
    <h2>Was wollen Sie überprüfen?</h2><br></br>
    <router-link to="/Pdoku"><button type="button" class="PD">Projektdokumentation</button></router-link>
    <router-link to="/Pprojekt"><button type="button" class="PP">Projektpräsentation</button></router-link>
    <router-link to="/Pfach"><button type="button" class="FG">Fachgespräch</button></router-link><br><br><br><br> 
    <router-link to="/Pges"><button type="button" class="GE">Gesamtergebnis</button></router-link>
    <router-link to="/Pmund"><button type="button" class="MP">Mündliche Prüfung</button></router-link>
  </div>
</template>

<script>
export default {
  name: 'YourComponentName'
}
</script>

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
      background-color: #07396e;
      color: white;
          border-radius: 20px;
    border: 4px double #cccccc;
  }

  .PP {
    margin-left: 20px;
      background-color: #07396e;
      color: white;
          border-radius: 20px;
    border: 4px double #cccccc;
  }

  .FG {
    margin-left: 20px;
      background-color: #07396e;
      color: white;
          border-radius: 20px;
    border: 4px double #cccccc;
  }

  .GE {
    margin-left: 20px;
      background-color: #07396e;
      color: white;
          border-radius: 20px;
    border: 4px double #cccccc;
  }

  .MP {
    margin-left: 20px;
      background-color: #07396e;
      color: white;
          border-radius: 20px;
    border: 4px double #cccccc;
  }
</style>
