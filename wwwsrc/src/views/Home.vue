<template>
  <div class="home">
    <h1>Welcome Home {{user.username}}</h1>
    <button v-if="user.id" @click="logout">logout</button>
    <router-link v-else :to="{name: 'login'}">Login</router-link>
  <div class="container-fluid"> 
    <div class="row">    
  <keep v-for="keep in keeps" :keepprop="keep" :key="keep.id" />
  <div class="col-12 pt-5"> 
  <CreateKeepsModal /> 
      </div>
    </div>
  </div>
  </div>
</template>

<script>
import CreateKeepsModal from "../Components/CreateKeepsModal"; 

export default {
  name: "home",
  data() {
    return {};
  },
  mounted() {
    this.$store.dispatch('getKeeps');
  },
  computed: {
    user() {
      return this.$store.state.user;
      return this.$store.state.keeps;
    }
  },
  methods: {
    logout() {
      this.$store.dispatch("logout");
    }
  },
  components: {
    CreateKeepsModal
  }

};
</script>

<style scoped> 

.home {
  background-color: blue; 
  width: 100vw;
  height: 15vh; 
  margin-left: 0px; 
  padding-left: 0px; 
}
h1 {
  color: white; 
}
</style> 