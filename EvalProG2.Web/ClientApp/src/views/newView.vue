<template>
  <div>
    <h2>Was wollen Sie tun?</h2>
    <div class="container">
      <div class="input-group mb-3">
        <span class="input-group-text" id="basic-addon1">Name von Prüfling</span>
        <input type="text" class="form-control" v-model="name" aria-label="test" aria-describedby="basic-addon1">
      </div>
      <div class="input-group mb-3">
        <span class="input-group-text" id="basic-addon1">Ausblidungsberuf</span>
        <input type="text" class="form-control" v-model="profession" aria-label="test" aria-describedby="basic-addon1">
      </div>
      <div class="input-group mb-3">
        <span class="input-group-text" id="basic-addon1">Prüfungstage</span>
        <input type="text" class="form-control" v-model="examDays" aria-label="test" aria-describedby="basic-addon1">
      </div>
    </div>
  </div>
</template>

<script>
export default {
  data() {
    return {
      name: '',
      profession: '',
      examDays: ''
    };
  }
};
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
  background-color: #007BFF;
  color: white;
}

.success {
  background-color: #28A745;
  color: white;
}

.danger {
  background-color: #ca0909;
  color: white;
}
</style>