<template>
<div class="nav container-fluid d-flex"> 
  <div class="row"> 
    <div class="col"> 
      <router-link to="/login" class="btn btn-secondary">Login</router-link> 
      <router-link to="/MyVault" class="btn btn-secondary">My Vault</router-link>
    </div> 
  </div>
</div>
</template>

<script>

export default {
  name: "navbar", 
  data() {
    return {};
  },
  computed: {},
  methods: {},
  components: {}, 
};
</script>

<style scoped> 
.nav {
  background: black; 
}
</style> 