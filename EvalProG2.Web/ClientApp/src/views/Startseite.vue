<template>
        <div class="container">
      <router-link to="/pruefen">
        <button class="primary">Prüflinge Überprüfen</button>
      </router-link>
      <br>
      <router-link to="/edit">
        <button class="danger">Prüfling bewerten</button>
      </router-link>
      <br>
      <router-link to="/IN_candidate">
        <button class="success">Prüfling hinzufügen</button>
      </router-link>
      <br>
            <router-link to="/IN_examiner">
        <button class="success">Prüfungsauschuss hinzufügen</button>
      </router-link>
  </div>
</template>

<script>
export default {
  name: 'Home'
}
</script>

<style scoped>
button {
  padding: 20px 40px;
  font-size: 40px;
  border: none;
  border-radius: 15px;
  cursor: pointer;
}
.container {
  text-align: center;
}

.primary {
  margin-top: 60px;
  background-color: red;
  color: white;

    border-radius: 20px;
    border: 4px double #cccccc;
}
 
.success {
  margin-top: 30px;
  background-color: red;
  color: white;
    border-radius: 20px;
    border: 4px double #cccccc;
}

.danger {
  margin-top: 30px;
  background-color: red;
  color: white;
    border-radius: 20px;
    border: 4px double #cccccc;
}
</style>
