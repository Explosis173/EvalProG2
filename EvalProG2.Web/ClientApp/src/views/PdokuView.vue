

   <template>
  <div>    <div class="container"> <h1>Dokumentation von Prüfling</h1>
       <button type="button" class="primary">
    <a href="newView.vue" class= "primary" download="doku.pdf">Dokumentation herunterladen</a></button>
    <button type="button" class="success">Dokumentation bewerten</button>
    </div>
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
  font-size: 30px;
  border: none;
  border-radius: 15px;
  cursor: pointer;
}

.container {
  text-align: center;
}

.primary {
  margin-top: 160px;
  background-color: red;
  color: white;
}

.success {
  margin-top: 30px;
  margin-left: 40px ;
  background-color: red;
  color: white;
}

.danger {
  margin-top: 30px;
  background-color: red;
  color: white;
}
</style>
