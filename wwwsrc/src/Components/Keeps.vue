<template>
<div class="keep"> 
  Keep Details 
  <img :src="car.imgUrl" alt /> 
  <h1>{{keep.name}}</h1> 
  <h1>{{keep.description}}</h1> 
  <span> {{keep.viewcount}} </span> 
  <span> {{keep.shares}} </span> 
  <span> {{keep.kept}} </span> 
  <button class="btn btn-danger" @click="remove">Delete</button> 
  </div> 
</template>


<script>
export default {
  name: "keep",
  data() {
    return {};
  },
  mounted() {
    let payload = {
      keepId: this.$route.params.keepId
    };
    this.$store.dispatch("getkeepById", payload); 
  }, 
  computed: {
    keep() {
      return this.$store.state.activeKeep; 
    }
  },
  methods: {
    remove() {
      this.$store.dispatch("deleteKeep", this.keep._id); 
  }
  }, 
  components: {}
};
</script>

<style scoped>
img {
  height: 500px; 
}
</style>