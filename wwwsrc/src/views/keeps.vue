<template>
  <div class="keeps container-fluid">
    <div class="row">
      <car v-for="keep in keeps" :carProp="keep" :key="keep._id" />
      <div class="col-12 pt-5">
        <CreateKeepsModal />
        <button class="btn btn-primary" data-toggle="modal" data-target="#create-keeps-modal">create keep</button>
      </div>
    </div>
  </div>
</template>


<script>
import CreateKeepsModal from "../Components/CreateKeepsModal.vue"

export default {
  name: 'keeps',
  mounted() {
    this.$store.dispatch("getKeeps");
  },
  data() {
    return {}; 
  },
  computed: {
    keeps() {
      return this.$store.state.keeps;
    }
  },
  methods:{
    addKeeps(user) {
      this.$store.dispatch("addKeeps", this.newKeep);
      this.newKeep = {
        name: "", 
        description: "", 
        img: "", 
      };
    },
    getKeeps() {
      this.$store.dispatch("getKeeps", this.keeps);
      this.keeps = {
        name: "", 
        description: "", 
        img: "", 
      }; 
    }
  },
  components:{CreateKeepsModal}
};
</script>


<style scoped>

</style>