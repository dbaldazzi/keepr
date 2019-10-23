<template>
  <div class="vault">
    <h1>Welcome To Your Vaults {{user.username}}</h1>
    <button class="btn btn-primary"><router-link to="/Keeps">Keeps</router-link></button> 
    <button class="btn btn-primary"><router-link to="/vault">Vault</router-link></button> 
    <button v-if="user.id" @click="logout">logout</button>
    <router-link v-else :to="{name: 'login'}">Login</router-link> 
  <div class="container-fluid"> 
    <div class="row">    
  <!-- <keep v-for="keep in keeps" :keepprop="keep" :key="keep.id" /> -->
  <div class="col-12 pt-5"> 
  <CreateKeepsModal /> 
      </div>
    </div>
  </div>
  </div>
</template>


<script>
import CreateKeepsModal from "../Components/CreateKeepsModal.vue" 

export default {
  name: 'vault',
  data(){
    return {}
  },
  mounted() {
    this.$store.dispatch('getvaults'); 
  },
  computed:{},
  methods:{
    logout() {
      this.$store.dispatch("logout");
  }
  },
  components: { CreateKeepsModal }
};

</script>


<style scoped> 
.router {
  color: white; 
}

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